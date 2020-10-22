using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pastel;

namespace DiscoScript.Core.Native.Objects
{
    public abstract partial class Objects
    {
        [JsonConverter(typeof(ObjectSerializer))]
        public class Object : INative, IAccessible, IIndexAccesible, IInternalValue<Dictionary<string, INative>>
        {
            protected Dictionary<string, INative> _natives;

            public Object() => _natives = new Dictionary<string, INative>();
            public Object(Dictionary<string, INative> values) => _natives = values;
            public void SetValue(string name, INative value)
            {
                _natives[name] = value;
            }

            public INative GetValue(string name)
            {
                return _natives.TryGetValue(name, out var value) ? value : new Undefined();
            }
            
            public PropertyData GetProperty(string name) => new PropertyData(name, GetValue(name), this);

            public PropertyData SetProperty(string name, INative value)
            {
                SetValue(name, value);
                return new PropertyData(name, value, this);
            }

            public bool Greater(INative b) => false;
            public bool Lesser(INative b) => false;

            public override string ToString()
            {
                return $"{{{string.Join(", ", _natives.Select(p => $"{p.Key}: {p.Value}"))}}}";
            }

            public Dictionary<string, INative> GetInternalValue() => _natives;

            public INative this[INative key]
            {
                get
                {
                    if (!(key is Text text))
                        throw new NativeException($"El índice de un objeto debe ser un texto");
                    
                    return !_natives.TryGetValue(text, out var ret) ? new Undefined() : ret;
                }
                set
                {
                    if (!(key is Text text))
                        throw new NativeException($"El índice de un objeto debe ser un texto");
                    _natives[text] = value;
                }
            }
        }
        
        public class ObjectSerializer : JsonConverter<Object>
        {
            public override void WriteJson(JsonWriter writer, Object value, JsonSerializer serializer)
            {
                var internalValue = value.GetInternalValue();
                serializer.Serialize(writer, internalValue);
            }

            public override Object ReadJson(JsonReader reader, Type objectType, Object existingValue, bool hasExistingValue,
                JsonSerializer serializer) => new Object(JToken.Load(reader).ToObject<Dictionary<string, INative>>()!);
        }
    }
}