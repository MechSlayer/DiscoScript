using System;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("consola")]
    public class ConsoleObject : IGlobal
    {
        [ShowAs("mostrar")]
        public Task<INative> Show(Scope scope, params INative[] args)
        {
            Console.WriteLine(args.FirstOrDefault());
            return Task.FromResult(new Undefined().As<INative>());
        }

        [ShowAs("limpiar")]
        public Task<INative> Clean(Scope scope, params INative[] args)
        {
            Console.Clear();
            return new Text("").ToTask();
        }

        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);

        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);

        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;
    }
}