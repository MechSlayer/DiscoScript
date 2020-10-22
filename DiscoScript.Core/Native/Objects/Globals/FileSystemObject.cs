using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native.Objects.Globals
{
    [ShowAs("Archivo")]
    public class FileSystemObject : IGlobal
    {

        [ShowAs("leer")]
        public async Task<INative> Read(Scope scope, params INative[] args)
        {
            if (!(args.ElementAtOrDefault(0) is Text text)) return new Undefined();
            if (!File.Exists(text)) throw new NativeException($"El archivo '{text}' no existe");
            return new Text(await File.ReadAllTextAsync(text));
        }
        
        [ShowAs("escribir")]
        public async Task<INative> Write(Scope scope, params INative[] args)
        {
            if (args.Length < 2) return new Undefined();
            if (!(args.ElementAtOrDefault(0) is Text path)) return new Undefined();
            if (!(args.ElementAtOrDefault(1) is Text text)) return new Undefined();
            await File.WriteAllTextAsync(path, text);
            return new Undefined();
        }
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public PropertyData GetProperty(string name) => new PropertyData(name, Helpers.GetMember(this, name).ToNative(this), this);

        public PropertyData SetProperty(string name, INative value) => new PropertyData(name, Helpers.SetMember(this, name, value).ToNative(this), this);
    }
}