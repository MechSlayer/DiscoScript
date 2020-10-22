using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class IfNode : Node
    {
        public Node Condition { get; }
        public Node Body { get; }
        public Node Else { get; }
        
        public IfNode(Node condition, Node body, Node @else,  IToken parseNode) : base(parseNode.ToPosition())
        {
            Condition = condition;
            Body = body;
            Else = @else;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var ifScope = new Scope(scope, ScopeKind.Condition);
            var condition = await Condition.ExecuteAsync(ifScope).GetResult();
            if (condition.ToBool())
                await Body.ExecuteAsync(ifScope);
            else
                await Else.ExecuteAsync(ifScope);
            return new Completion();
        }
    }
}