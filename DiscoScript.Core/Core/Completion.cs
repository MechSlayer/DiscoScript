using DiscoScript.Common;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Core
{
    public readonly struct Completion : ICompletion<INative>
    {
        public INative Result { get; }
        public bool Continue { get; }

        public Completion(INative? result = null, bool @continue = true)
        {
            Result = result ?? new Undefined();
            Continue = @continue;
        }
        
        public static Completion New() => new Completion(null, true);
    }
}