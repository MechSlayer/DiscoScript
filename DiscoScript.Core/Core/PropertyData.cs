using DiscoScript.Common;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Core
{
    public readonly struct PropertyData : INative, ICompletion<INative>, IInternalValue<INative>
    {
        public INative Result { get; }
        public IAccessible Object { get; }
        public string Name { get; }

        public PropertyData(string name, INative result, IAccessible obj)
        {
            Name = name;
            Result = result;
            Object = obj;
        }

        public override string ToString()
        {
            return Result.ToString()!;
        }

        public void Set(INative value) => Object.SetProperty(Name, value);
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public INative GetInternalValue() => Result;
    }
}