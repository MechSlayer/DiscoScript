using System;
using System.Drawing;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    [JsonConverter(typeof(TextSerializer))]
    public readonly struct Text : INative, IAccessible, IInternalValue<string>
    {
        private readonly string _value;

        public Text(string value)
        {
            _value = value;
        }


        public static bool operator ==(Text a, Text b) => a._value == b._value;
        public static bool operator !=(Text a, Text b) => !(a == b);

        
        public static bool operator <(Text a, Text b) => a.Length < b.Length;
        public static bool operator >(Text a, Text b) => a.Length > b.Length;
        public static bool operator <=(Text a, Text b) => a.Length <= b.Length;
        public static bool operator >=(Text a, Text b) => a.Length >= b.Length;
        
        public static Text operator +(Text a, Number b) => new Text(a._value + b.GetInternalValue()!);
        public static Text operator +(Text a, Text b) => new Text(a._value + b._value);

        public static Text operator *(Text a, Number b)
        {
            var start = a._value;
            var res = start;
            for (var i = 0; i < b; i++)
                res += start;
            
            return new Text(res);
        }

        public static implicit operator string(Text text) => text._value;
        public static implicit operator Text(string str) => new Text(str);
        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);
        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);

        public override string ToString()
        {
            return $"{_value.Pastel(Color.LimeGreen)}";
        }

        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text(_value).As<INative>());

        [ShowAs("longitud")]
        public Number Length => _value.Length;

        public bool Greater(INative b)
        {
            return b switch
            {
                Text text => this > text,
                Number number => Length > number,
                _ => false
            };
        }

        public bool Lesser(INative b)
        {
            return b switch
            {
                Text text => this < text,
                Number number => Length < number,
                _ => false
            };
        }

        public string GetInternalValue() => _value;
    }
    
    public class TextSerializer : JsonConverter<Text>
    {
        public override void WriteJson(JsonWriter writer, Text value, JsonSerializer serializer)
        {
            writer.WriteValue(value.GetInternalValue());
        }

        public override Text ReadJson(JsonReader reader, Type objectType, Text existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Text(JToken.Load(reader).ToString());
        }
    }
}