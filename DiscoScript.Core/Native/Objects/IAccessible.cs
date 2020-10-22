using DiscoScript.Common;
using DiscoScript.Core.Core;

namespace DiscoScript.Core.Native.Objects
{
    public interface IAccessible
    {
        PropertyData GetProperty(string name);
        PropertyData SetProperty(string name, INative value);
    }
}