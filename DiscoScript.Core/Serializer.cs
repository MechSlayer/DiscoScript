using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscoScript.Core
{
    [ShowAs("JSON")]
    public class Serializer : IGlobal
    {
        [ShowAs("serializar")]
        public Task<INative> Serialize(Scope scope, params INative[] args)
        {
            var value = args.ElementAtOrDefault(0);
            if (value == null) throw new NativeException("Se requiere un objeto para serializar");
            var indented = args.ElementAtOrDefault(1) is Bool bol && bol ? Formatting.Indented : Formatting.None;
            var res = JsonConvert.SerializeObject(value, indented);
            return Task.FromResult(new Text(res).As<INative>());
        }

        [ShowAs("deserializar")]
        public Task<INative> Deserialize(Scope scope, params INative[] args)
        {
            var value = args.ElementAtOrDefault(0);
            if (value == null || !value.Is<Text>(out var text)) throw new NativeException("Se requiere un texto para deserializar");
            var token = JToken.Parse(text);
            INative result = token switch
            {
                JArray array => array.ToObject<Objects.Array>()!,
                JObject jObject => jObject.ToObject<Objects.Object>()!,
                _ => new Undefined()
            };

            return Task.FromResult(result);
        }

        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => new PropertyData(string.Empty, new Undefined(), this);

        public PropertyData SetProperty(string name, INative value) => new PropertyData(string.Empty, new Undefined(), this);
    }
}