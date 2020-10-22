using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class ObjectMember : Node
    {
        public Identifier Id { get; }
        public Node Init { get; }

        public ObjectMember(Identifier id, Node init, IToken parseNode) : base(parseNode?.ToPosition())
        {
            Id = id;
            Init = init;
        }

        public override string ToString()
        {
            return $"{Id}: {Init}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            return await Init.ExecuteAsync(scope);
        }
    }
}