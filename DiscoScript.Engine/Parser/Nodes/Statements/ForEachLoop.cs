using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Statements
{
    public class ForEachLoop : Node
    {
        public Identifier Init { get; }
        public Node Target { get; }
        public Node Body { get; }
        public ForEachLoop(Identifier init, Node target, Node body, IToken? parseToken) : base(parseToken?.ToPosition())
        {
            Init = init;
            Target = target;
            Body = body;
        }

        public override string ToString()
        {
            return $"por_cada(var {Init} en {Target}) {Body}";
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var loopScope = new Scope(scope, ScopeKind.Loop);
            var target =  await Target.ExecuteAsync(scope).GetResult();
            if (!(target is Objects.Array array)) throw new NativeException($"'{target.GetShowAs()}' no es un array");
            loopScope.DeclareVariable(Init);
            foreach (var element in array)
            {
                loopScope.AssignVariable(Init, element);
                var res = await Body.ExecuteAsync(scope);
                if (res is Completion completion && !completion.Continue)
                    return res;
            }
            return new Completion(new Undefined());
        }
    }
}