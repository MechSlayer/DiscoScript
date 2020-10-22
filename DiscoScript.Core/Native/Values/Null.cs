using System;
using System.Drawing;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using Newtonsoft.Json;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    [ShowAs("nulo")]
    [JsonConverter(typeof(NullSerializer))]
    public readonly struct Null : INative
    {
        private static readonly string stringValue = "nulo".Pastel(Color.White);
        public bool Equals(Null other)
        {
            return true;
        }

        
        public bool Greater(INative b)
        {
            return false;
        }

        public bool Lesser(INative b)
        {
            return false;
        }

        public override bool Equals(object? obj)
        {
            return obj is Null other && Equals(other);
        }

        public override string ToString() => stringValue;

        public override int GetHashCode()
        {
            return 0;
        }
        
        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text("nulo").As<INative>());
    }
    
    public class NullSerializer : JsonConverter<Null>
    {
        public override void WriteJson(JsonWriter writer, Null value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, null);
        }

        public override Null ReadJson(JsonReader reader, Type objectType, Null existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Null();
        }
    }
}