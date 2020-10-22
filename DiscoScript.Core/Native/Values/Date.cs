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
    [ShowAs("fecha")]
    [JsonConverter(typeof(DateSerializer))]
    public readonly struct Date : INative, IAccessible, IInternalValue<DateTime>
    {
        private readonly DateTime _value;

        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0);  
        public Date(double value) => _value = UnixEpoch.AddSeconds(value);
        public Date(DateTime date) => _value = date;

        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);
        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);

        public override string ToString()
        {
            return _value.ToString(CultureInfo.CurrentCulture).Pastel(Color.Purple);
        }
        
        #region Arithmetic

        public static Date operator +(Date a, Date b) => new Date(a._value + new TimeSpan(b._value.Ticks));
        public static Date operator -(Date a, Date b) => a._value.Subtract(new TimeSpan(b._value.Ticks));

        #endregion



        #region Equality

        public static bool operator ==(Date a, Date b) => a._value == b._value;
        public static bool operator !=(Date a, Date b) => !(a == b);
        public static bool operator <(Date a, Date b) => a._value < b._value;
        public static bool operator >(Date a, Date b) => a._value > b._value;
        public static bool operator >(Date a, Number b) => a._value.Second > b;
        public static bool operator <(Date a, Number b) => a._value.Second < b;
        public static bool operator <=(Date a, Date b) => a._value <= b._value;
        public static bool operator >=(Date a, Date b) => a._value >= b._value;

        #endregion


        public static implicit operator DateTime(Date date) => date._value;
        public static implicit operator Date(DateTime date) => new Date(date);
        public bool Greater(INative b)
        {
            if (b is Date date) return this > date;
            if (b is Number number) return _value.Second > number;
            return false;
        }

        public bool Lesser(INative b)
        {
            if (b is Date date) return this < date;
            if (b is Number number) return _value.Second < number;
            return false;
        }
        
        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text(_value.ToString(CultureInfo.InvariantCulture)).As<INative>());

        public DateTime GetInternalValue() => _value;
    }
    
    public class DateSerializer : JsonConverter<Date>
    {
        public override void WriteJson(JsonWriter writer, Date value, JsonSerializer serializer)
        {
            writer.WriteValue(value.GetInternalValue());
        }

        public override Date ReadJson(JsonReader reader, Type objectType, Date existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Date(JToken.Load(reader).ToObject<DateTime>());
        }
    }
}