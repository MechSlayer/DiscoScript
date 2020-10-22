using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("Objeto")]
    public class ObjectObject : IGlobal
    {

        [ShowAs("claves")]
        public Task<INative> Keys(Scope scope, params INative[] args)
        {
            var val = args.ElementAtOrDefault(0);
            if (val == null || !(val is Objects.Object obj)) return new Undefined().ToTask();
            var dic = obj.GetInternalValue();
            return new Objects.Array(dic.Keys.GetEnumerator()).ToTask();
        }
        
        [ShowAs("valores")]
        public Task<INative> Values(Scope scope, params INative[] args)
        {
            var val = args.ElementAtOrDefault(0);
            if (val == null || !(val is Objects.Object obj)) return new Undefined().ToTask();
            var dic = obj.GetInternalValue();
            return new Objects.Array(dic.Values.GetEnumerator()).ToTask();
        }
        

        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);

        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);
    }
}