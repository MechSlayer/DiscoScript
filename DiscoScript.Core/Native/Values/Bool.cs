using System;
using System.Drawing;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    
    [JsonConverter(typeof(BoolSerializer))]
    public readonly struct Bool : INative, IEquatable<Bool>, IInternalValue<bool>
    {
        private readonly bool _value;

        public Bool(bool value)
        {
            _value = value;
        }
        
        public static implicit operator bool(Bool boolean) => boolean._value;
        public static implicit operator Bool(bool boolean) => new Bool(boolean);

        public override bool Equals(object? obj)
        {
            return obj is Bool other && Equals(other);
        }

        public bool Equals(Bool other)
        {
            return _value == other._value;
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override string ToString()
        {
            return (_value ? "verdadero" : "falso").Pastel(Color.Blue);
        }


        public bool Greater(INative b)
        {
            if (b is Bool bol) return !bol._value && _value;
            return false;
        }

        public bool Lesser(INative a)
        {
            if (a is Bool bol) return bol._value && !_value;
            return false;
        }
        
        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text(_value ? "verdadero" : "falso").As<INative>());

        public bool GetInternalValue() => _value;
    }
    
    
    public class BoolSerializer : JsonConverter<Bool>
    {
        public override void WriteJson(JsonWriter writer, Bool value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value.GetInternalValue());
        }

        public override Bool ReadJson(JsonReader reader, Type objectType, Bool existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Bool(JToken.Load(reader).ToObject<bool>());
        }
        
    }
}