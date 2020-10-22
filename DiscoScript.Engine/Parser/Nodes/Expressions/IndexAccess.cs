using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class IndexAccess : Node
    {
        public Node Target { get; }
        public Node Index { get; }
        public IndexAccess(Node target, Node index, IToken? parseNode) : base(parseNode?.ToPosition())
        {
            Target = target;
            Index = index;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var target = await Target.ExecuteAsync(scope).GetResult();
            if (!(target is IIndexAccesible indexAccesible))
                throw new NativeException($"'{target.GetShowAs()}' no dispone de índice");

            var index = await Index.ExecuteAsync(scope).GetResult();
            return new Completion(indexAccesible[index]);
        }
    }
}