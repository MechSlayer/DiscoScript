using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Common.Exceptions;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native
{
    public class Scope : IAccessible, INative, IScope<PropertyData, INative>, IEnumerable<KeyValuePair<string, INative>>, IInternalValue<Dictionary<string, INative>>
    {
        public Dictionary<string, INative> Variables { get; protected set; }
        public ScopeKind Kind { get; protected set; }
        public Scope? Parent { get; protected set; }
        
        public GlobalScope GlobalScope { get; protected set; }
        public Scope(Scope? parent, GlobalScope globalScope, ScopeKind kind) : this()
        {
            Kind = kind;
            Parent = parent;
            GlobalScope = globalScope;
        }

        public Scope(Scope parent, ScopeKind kind) : this(parent, parent.GlobalScope, kind)
        {
            
        }

        public Scope()
        {
            Variables = new Dictionary<string, INative>();
        }

        public Scope CreateChild(ScopeKind kind, bool independent = false)
        {
            return independent ? new Scope(GlobalScope, kind) : new Scope(this, kind);
        }
        
        public bool GetTargetScope(string varName, out Scope targetScope)
        {
            targetScope = this;
            while (!targetScope.Variables.ContainsKey(varName))
            {
                if (targetScope.Parent == null)
                {
                    targetScope = this;
                    return false;
                }

                targetScope = targetScope.Parent;
            }

            return targetScope.Variables.ContainsKey(varName);
        }

        public PropertyData DeclareVariable(string name)
        {
            if (GetTargetScope(name, out var scope))
                throw new NativeException($"'{name}' ya está definido");
            Variables.Add(name, new Undefined());
            return new PropertyData(name, this, this);
        }

        public PropertyData AssignVariable(string name, INative value)
        {
            if (!GetTargetScope(name, out var scope)) throw new NativeException($"'{name}' no está definido");
            scope.Variables[name] = value;
            return new PropertyData(name, value, this);
        }

        public PropertyData FindVariable(string name)
        {
            var value = !GetTargetScope(name, out var scope) ? new Undefined() : scope.Variables[name];
            return new PropertyData(name, value, this);
        }

        public PropertyData GetProperty(string name)
        {
            return new PropertyData(name, FindVariable(name), this);
        }

        public PropertyData SetProperty(string name, INative value)
        {
            return new PropertyData(name, AssignVariable(name, value), this);
        }

        public void Add(string name, INative value)
        {
            DeclareVariable(name).Set(value);
        }

        public bool Greater(INative b) => false;

        public bool Lesser(INative b) => false;

        public IEnumerator<KeyValuePair<string, INative>> GetEnumerator()
        {
            return Variables.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        public Dictionary<string, INative> GetInternalValue() => Variables;
    }
}