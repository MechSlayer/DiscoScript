using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class ForILoop : Node
    {
        public Node Init { get; }
        public Node Condition { get; }
        public Node Update { get; }
        public Node Body { get; }
        public ForILoop(Node init, Node condition, Node update, Node body, IToken? parseToken) : base(parseToken?.ToPosition())
        {
            Init = init;
            Condition = condition;
            Update = update;
            Body = body;
        }

        public override string ToString()
        {
            return $"por_cada({Init}; {Condition}; {Update};) {Body}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var loopScope = new Scope(scope, ScopeKind.Loop);
            await Init.ExecuteAsync(loopScope).GetResult();
            while ((await Condition.ExecuteAsync(loopScope).GetResult()).ToBool())
            {
                await Body.ExecuteAsync(loopScope);
                await Update.ExecuteAsync(loopScope);
            }
            return new Completion();
        }
    }
}