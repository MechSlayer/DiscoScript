using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscoScript.Core.Native.Objects
{
    
    public abstract partial class Objects
    {
        [JsonConverter(typeof(ArraySerializer))]
        public class Array : INative, IAccessible, IIndexAccesible, IEnumerable<INative>, IInternalValue<List<INative>>
        {
            private readonly List<INative> _natives;

            public Array(IEnumerable array)  : this()
            {
                foreach (var item in array)
                    _natives.Add(item.ToNative());
            }

            public Array(IEnumerator enumerator)
            {
                _natives = new List<INative>();
                while (enumerator.MoveNext())
                    _natives.Add(enumerator.Current.ToNative());
            }

            public Array() => _natives = new List<INative>();

            public INative GetIndex(int index)
            {
                return _natives.ElementAtOrDefault(index) ?? new Undefined();
            }

            public void SetIndex(int index, INative value)
            {
                _natives.Insert(index, value);
            }
            
            
            public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);
            public PropertyData SetProperty(string name, INative value) => new PropertyData(name, value, this);

            public bool Greater(INative b)
            {
                return b switch
                {
                    Array array => _natives.Count > array._natives.Count,
                    Number number => _natives.Count > number,
                    _ => false
                };
            }

            public bool Lesser(INative b)
            {
                return b switch
                {
                    Array array => _natives.Count < array._natives.Count,
                    Number number => _natives.Count < number,
                    _ => false
                };
            }

            public IEnumerator<INative> GetEnumerator()
            {
                return _natives.GetEnumerator();
            }

            public override string ToString()
            {
                if (_natives.Count <= 40) return $"[{string.Join(", ", _natives)}]";
                var first = _natives.First();
                var last = _natives.Last();
                return $"[{first}...{_natives.Count - 2} elementos...{last}]";
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public List<INative> GetInternalValue() => _natives;

            public void Add(INative native) => _natives.Add(native);

            [ShowAs("longitud")]
            public Number Length => _natives.Count;
            

            [ShowAs("agregar")]
            public Task<INative> Push(Scope scope, params INative[] args)
            {
                var value = args.ElementAtOrDefault(0);
                if (value == null) return new Undefined().ToTask();
                _natives.Add(value);
                return value.ToTask();
            }
            
            [ShowAs("quitar")]
            public Task<INative> Remove(Scope scope, params INative[] args)
            {
                return args.Length == 0 ? new Bool(false).ToTask() : _natives.Remove(args.ElementAtOrDefault(0)).ToNative().ToTask();
            }
            
            [ShowAs("quitarEn")]
            public Task<INative> RemoveAt(Scope scope, params INative[] args)
            {
                if (!(args.ElementAtOrDefault(0) is Number number)) return new Bool(false).ToTask();
                var max = _natives.Count - 1;
                if (number <= max) _natives.RemoveAt(number);
                return (number <= max).ToNative().ToTask();
            }

            [ShowAs("llenar")]
            public Task<INative> Fill(Scope scope, params INative[] args)
            {
                var value = args.ElementAtOrDefault(0) ?? new Number(100);
                if (!(value is Number number)) return this.ToTask();
                if (_natives.Count >= number) return this.ToTask();
                for (var i = 0; i < number; i++)
                    _natives.Add(new Number(i));
                return this.ToTask();
            }

            [ShowAs("aleatorio")]
            public Task<INative> Random(Scope scope, params INative[] args)
            {
                var minIndex = args.ElementAtOrDefault(0) is Number number && number >= 0 ? number : new Number(0);
                var maxIndex = args.ElementAtOrDefault(1) is Number maxNumber
                    ? maxNumber
                    : new Number(_natives.Count - 1);

                maxIndex = Math.Min(maxIndex, _natives.Count - 1);

                return this[new Number(new Random().Next(minIndex, maxIndex))].ToTask();
            }
            

            public INative this[INative key]
            {
                get
                {
                    if (!(key is Number number))
                        throw new NativeException($"El índice de un array debe ser un número");

                    return _natives.ElementAtOrDefault(number) ?? new Undefined();
                }
                set
                {
                    if (!(key is Number number))
                        throw new NativeException($"El índice de un array debe ser un número");

                    if (number > _natives.Count - 1)
                    {
                        for (var i = _natives.Count - 1; i < number; i++)
                            _natives.Add(new Undefined());
                    }

                    _natives[number] = value;
                }
            }
        }
        
        
        public class ArraySerializer : JsonConverter<Array>
        {
            public override void WriteJson(JsonWriter writer, Array value, JsonSerializer serializer)
            {
                var internalValue = value.GetInternalValue();
                serializer.Serialize(writer, internalValue);
            }

            public override Array ReadJson(JsonReader reader, Type objectType, Array existingValue,
                bool hasExistingValue,
                JsonSerializer serializer)
            {
                var array = new Array();
                var jArray = JArray.Load(reader);
                foreach (var token in jArray)
                {
                    var toAdd = token switch
                    {
                        JArray arr => arr.ToObject<Array>(),
                        JObject obj => obj.ToObject<Object>(),
                        _ => token.ToObject<INative>()
                    };
                    array.Add(toAdd!);
                }

                return array;
            }
            
        }
    }
}