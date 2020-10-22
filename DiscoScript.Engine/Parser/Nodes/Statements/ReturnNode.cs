using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class ReturnNode : Node
    {
        public Node Init { get; }

        public ReturnNode(Node init, IToken parseNode) : base(parseNode.ToPosition())
        {
            Init = init;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var res = await Init.ExecuteAsync(scope).GetResult();
            return new Completion(res, false);
        }

        public override string ToString()
        {
            return $"devolver {Init}";
        }
    }
}