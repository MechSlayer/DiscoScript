using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("Promesa")]
    public class PromiseObject : IGlobal
    {
        [ShowAs("esperar")]
        public async Task<INative> Wait(Scope scope, params INative[] args)
        {
            var time = args.ElementAtOrDefault(0) is Number number ? number : new Number();
            await Task.Delay(time * 1000);
            return new Undefined();
        }
        
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);

        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);
    }
}