using System;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    [ShowAs("número")]
    [JsonConverter(typeof(NumberSerializer))]
    public readonly struct Number : INative, IAccessible, IInternalValue<double>
    {
        private readonly double _value;
        
        public static readonly Number NaN = new Number(double.NaN);
        [ShowAs("esPositivo")]
        public Bool IsPositive { get; }
        

        public Number(double value)
        {
            _value = value;
            IsPositive = value >= 0;
        }

        #region Arithmetic

        public static Number operator +(Number a, Number b) => new Number(a._value + b._value);
        public static Number operator -(Number a, Number b) => new Number(a._value - b._value);
        public static Number operator *(Number a, Number b) => new Number(a._value * b._value);
        public static Number operator /(Number a, Number b) => new Number(a._value / b._value);
        public static Number operator %(Number a, Number b) => new Number(a._value % b._value);

        #endregion



        #region Equality

        public static bool operator ==(Number a, Number b) => a._value == b._value;
        public static bool operator !=(Number a, Number b) => !(a == b);
        public static bool operator <(Number a, Number b) => a._value < b._value;
        public static bool operator >(Number a, Number b) => a._value > b._value;
        public static bool operator <=(Number a, Number b) => a._value <= b._value;
        public static bool operator >=(Number a, Number b) => a._value >= b._value;

        #endregion

        #region Conversions

        public static implicit operator Number(double num) => new Number(num);

        public static implicit operator double(Number number) => number._value;
        public static implicit operator int(Number number) => Convert.ToInt32(number._value);
        #endregion
        
        public override bool Equals(object? obj)
        {
            return obj is Number number && Equals(number);
        }
        
        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);
        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);

        public bool Greater(INative b)
        {
            return b switch
            {
                Number number => this > number,
                Text text => this > text.Length,
                Date date => new Date(_value) > date,
                _ => false
            };
        }

        public bool Lesser(INative b)
        {
            return b switch
            {
                Number number => this < number,
                Text text => this < text.Length,
                Date date => new Date(_value) < date,
                _ => false
            };
        }

        public bool Equals(Number other)
        {
            return _value.Equals(other._value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }


        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text(_value.ToString(CultureInfo.InvariantCulture)).As<INative>());
        
        public override string ToString()
        {
            return $"{_value.ToString(CultureInfo.InvariantCulture).Pastel(Color.DarkOrange)}";
        }

        public double GetInternalValue() => _value;
    }
    
    public class NumberSerializer : JsonConverter<Number>
    {
        public override void WriteJson(JsonWriter writer, Number value, JsonSerializer serializer)
        {
            writer.WriteValue(value.GetInternalValue());
        }

        public override Number ReadJson(JsonReader reader, Type objectType, Number existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            return new Number(JToken.Load(reader).ToObject<double>());
        }
    }
}