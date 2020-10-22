using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class FunctionCall : Node
    {
        public Node Target { get; }
        public NodesCollection<Node> Params { get; }
        public bool IsAsync { get; }

        public FunctionCall(Node target, NodesCollection<Node> @params, IToken parseNode, bool isAsync = false) : base(parseNode?.ToPosition())
        {
            Target = target;
            Params = @params;
            IsAsync = isAsync;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var target = await Target.ExecuteAsync(scope).GetResult();
            if (!target.Is<Function>(out var function)) throw new NativeException($"'{Target}' no es una función", Position);
            var args = new INative[Params.Count];
            for (var i = 0; i < args.Length; i++)
                args[i] = await Params[i].ExecuteAsync(scope).GetResult();

            if (IsAsync) return new Completion(new Promise(function.InvokeAsync(scope, args)));
            return await function.InvokeAsync(scope, args);
        }

        public override string ToString()
        {
            return $"{(IsAsync ? "<-" : "")}{Target}({string.Join(", ", Params)})";
        }
    }
}