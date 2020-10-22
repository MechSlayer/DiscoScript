using System.Collections.Generic;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native
{
    public class GlobalScope : Scope
    {
        public GlobalScope()
        {
            GlobalScope = this;
            Parent = null;
            Kind = ScopeKind.Global;
            Helpers.LoadGlobals(this);
        }
    }
}