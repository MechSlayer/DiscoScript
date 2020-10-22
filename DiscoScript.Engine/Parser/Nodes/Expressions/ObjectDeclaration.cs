using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class ObjectDeclaration : Node
    {
        public NodesCollection<ObjectMember> Members { get; }

        public ObjectDeclaration(NodesCollection<ObjectMember> members, IToken parseNode) : base(parseNode?.ToPosition())
        {
            Members = members;
        }

        public override string ToString()
        {
            return $"{{{string.Join(",\n", Members)}}}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var obj = new Objects.Object();
            foreach (var member in Members)
                obj.SetValue(member.Id, await member.ExecuteAsync(scope).GetResult());
            return new Completion(obj);
        }
    }
}