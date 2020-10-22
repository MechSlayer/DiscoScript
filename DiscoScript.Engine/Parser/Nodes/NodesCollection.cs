using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Antlr4.Runtime;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Values;
using DiscoScript.Engine.Parser.Nodes.Statements;

namespace DiscoScript.Engine.Parser.Nodes
{
    
    public class NodesCollection <T> : Node, IList<T> where T : Node
    {
        protected readonly List<T> _list;

        public NodesCollection(IToken parseNode) : base(parseNode.ToPosition()) => _list = new List<T>();

        public NodesCollection(IEnumerable<T> toCopy, IToken parseNode) : base(parseNode.ToPosition())
        {
            _list = toCopy.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _list).GetEnumerator();
        }

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        public T this[int index]
        {
            get => _list[index];
            set => _list[index] = value;
        }

        public override string ToString()
        {
            return string.Join("\n", _list);
        }

        public void AddRange(IEnumerable<T> nodes)
        {
            foreach(var node in nodes) _list.Add(node);
        }
        
        public void AddRange(params T[] nodes)
        {
            foreach(var node in nodes) _list.Add(node);
        }

        public override async Task<ICompletion<INative>> ExecuteAsync(Scope scope)
        {
            ICompletion<INative> last = new Completion(new Undefined());
            foreach (var node in this)
            {
                if (node is ReturnNode returnNode)
                    return await returnNode.ExecuteAsync(scope);
                last = await node.ExecuteAsync(scope);
            }

            return last;
        }

        public IReadOnlyList<T> AsReadOnly() => _list.AsReadOnly();
    }
}