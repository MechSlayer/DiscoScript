using System;
using System.Drawing;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using Newtonsoft.Json;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    [ShowAs("indefinido")]
    [JsonConverter(typeof(UndefinedSerializer))]
    public readonly struct Undefined : INative
    {
        private static readonly string stringValue = "indefinido".Pastel(Color.DimGray);
        public override bool Equals(object? obj)
        {
            return obj is Undefined;
        }

        public bool Equals(Undefined other)
        {
            return true;
        }

        public INative GetProperty(string name) => new Undefined();
        public bool Greater(INative b) => false;
        public bool Lesser(INative b) => false;

        public override string ToString() => stringValue;
        
        [ShowAs("aTexto")]
        public Task<INative> ToString(Scope scope, params INative[] natives) =>
            Task.FromResult(new Text("indefinido").As<INative>());

        public override int GetHashCode()
        {
            return 0;
        }

        public T GetInternalValue<T>() => default!;
    }
    
    public class UndefinedSerializer : JsonConverter<Undefined>
    {
        public override void WriteJson(JsonWriter writer, Undefined value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, null);
        }

        public override Undefined ReadJson(JsonReader reader, Type objectType, Undefined existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return new Undefined();
        }
    }
}