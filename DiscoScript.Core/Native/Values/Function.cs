using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Core.Core;
using Pastel;

namespace DiscoScript.Core.Native.Values
{
    public readonly struct Function : INative, IInternalValue<Delegate>
    {
        public delegate Task<INative> FunctionDelegate(Scope scope, params INative[] args);
        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public string Name { get; }
        public FunctionDelegate Delegate { get; }
        public IReadOnlyList<Node<INative, Scope>> Parameters { get; }
        public IReadOnlyList<Node<INative, Scope>> Body { get; }
        public bool IsNative { get; }

        public Function(string name, IReadOnlyList<Node<INative, Scope>> parameters, IReadOnlyList<Node<INative, Scope>> body)
        {
            Name = name;
            Delegate = default!;
            Body = body;
            Parameters = parameters;
            IsNative = true;
            var self = this;
            Delegate = (scope, args) => self.NativeMethod(scope, args);
        }
        
        public Function(string name, object? target, MethodInfo method)
        {
            Name = name;
            Body = new List<Node<INative, Scope>>().AsReadOnly();
            Parameters = new List<Node<INative, Scope>>().AsReadOnly();
            IsNative = false;
            var @delegate = System.Delegate.CreateDelegate(typeof(FunctionDelegate), target, method) as FunctionDelegate;
            Delegate = @delegate ?? throw new Exception("Target method does not qualify");
        }

        public Function(string name, FunctionDelegate functionDelegate) : this(name, functionDelegate.Target, functionDelegate.Method)
        {
        }


        public async Task<Completion> InvokeAsync(Scope scope, params INative[] args)
        {
            return IsNative ? new Completion(await NativeMethod(scope, args)) : new Completion(await Delegate(scope, args));
        }
        private async Task<INative> NativeMethod(Scope scope, params INative[] args)
        {
            var funcScope = scope.CreateChild(ScopeKind.Function);
            var length = Math.Min(args.Length, Parameters.Count);
            for (var i = 0; i < length; i++)
                funcScope.DeclareVariable(Parameters[i].ToString()).Result.As<Scope>().AssignVariable(Parameters[i].ToString(), args[i]);

            var res = await Body.ExecuteAsync(funcScope);
            return (res.Result as INative)!;
        }
        public override string ToString()
        {
            return $"función {Name}".Pastel(Color.CornflowerBlue);
        }

        public Delegate GetInternalValue() => Delegate;
    }
}