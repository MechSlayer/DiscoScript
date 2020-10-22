using System;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("Mates")]
    public class MathObject : IGlobal
    {

        [ShowAs("aleatorio")]
        public Task<INative> Random(Scope scope, params INative[] args)
        {
            var min = args.ElementAtOrDefault(0) is Number number ? number : new Number(int.MinValue);
            var max = args.ElementAtOrDefault(1) is Number numberMax ? numberMax : new Number(int.MaxValue);
            var range = max - min;
            var random = new Random();
            return new Number(random.NextDouble() * range + min).ToTask();
        }
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => Helpers.GetProperty(this, name);

        public PropertyData SetProperty(string name, INative value) => Helpers.SetProperty(this, name, value);
    }
}