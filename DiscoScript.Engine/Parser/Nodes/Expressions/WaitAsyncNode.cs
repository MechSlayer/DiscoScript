using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Engine.Parser.Nodes.Expressions
{
    public class WaitAsyncNode : Node
    {
        public Node Target { get; }

        public WaitAsyncNode(Node target, IToken parseNode) : base(parseNode?.ToPosition())
        {
            Target = target;
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            var target = await Target.ExecuteAsync(scope).GetResult();
            if (!(target is Promise promise)) return new Completion(new Undefined());
            await promise.PromisedTask;
            var result = promise.PromisedTask.GetType().GetProperty("Result")?.GetValue(promise.PromisedTask);
            return result as ICompletion<INative> ?? new Completion(new Undefined());
        }
    }
}