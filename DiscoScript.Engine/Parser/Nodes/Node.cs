using DiscoScript.Common;
using DiscoScript.Core.Native;

namespace DiscoScript.Engine.Parser.Nodes
{
    public abstract class Node : Node<INative, Scope>
    {
        protected Node(CodePosition? position) : base(position)
        {
        }
    }
}