using System;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("Global")]
    public class GlobalObject : IGlobal
    {

        private readonly Objects.Object _values;

        public GlobalObject()
        {
            _values = new Objects.Object();
        }
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => _values.GetProperty(name);

        public PropertyData SetProperty(string name, INative value) => _values.SetProperty(name, value);

    }
}