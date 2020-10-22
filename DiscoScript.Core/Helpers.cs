using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Core.Attributes;
using DiscoScript.Core.Core;
using DiscoScript.Core.Native;
using DiscoScript.Core.Native.Objects;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core
{
    public class Helpers
    {

        public static PromiseStatus TaskStatusToPromise(Task task)
        {
            return task.Status switch
            {
                TaskStatus.RanToCompletion => PromiseStatus.Completed,
                TaskStatus.Faulted => PromiseStatus.Errored,
                TaskStatus.Canceled => PromiseStatus.Completed,
                _ => PromiseStatus.Pending
            };
        }

        public static bool IsNumeric(object? obj)
        {
            return obj is byte || obj is sbyte || obj is short || obj is ushort || 
                   obj is int || obj is uint || obj is long || obj is ulong || 
                   obj is float || obj is double || obj is decimal;
        }
        
        public static bool IsNumeric(Type? obj)
        {
            return obj == typeof(byte) || obj == typeof(sbyte) ||
                   obj == typeof(short) || obj == typeof(ushort) || 
                   obj == typeof(int) || obj == typeof(uint) ||
                   obj == typeof(long) || obj == typeof(ulong) || 
                   obj == typeof(ulong) || obj == typeof(double) || 
                   obj == typeof(decimal);
        }

        public static void LoadGlobals(Scope globalScope)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var types = new List<Type>();
            foreach (var assembly in assemblies)
            {
                var typesB = assembly.GetTypes().Where(t => !t.IsInterface && !t.IsAbstract && typeof(IGlobal).IsAssignableFrom(t));
                types.AddRange(typesB);
            }

            foreach (var type in types)
            {
                var obj = new Objects.Object();
                var instance = Activator.CreateInstance(type);
                globalScope.Variables[type.GetShowAs()] = obj;
                var members = type.GetMembers().Where(m => m.GetCustomAttribute<ShowAsAttribute>() != null);
                foreach (var member in members)
                    obj.SetValue(member.GetCustomAttribute<ShowAsAttribute>()!.Text!, member.ToNative(instance));
            }
        }
        
        public static MemberInfo GetMember(object obj, string name)
        {
            var type = obj.GetType();
            var member = type.GetMembers().FirstOrDefault(n => n.GetCustomAttribute<ShowAsAttribute>()?.Text == name);
            return member;
        }

        public static object? SetMember(object obj, string name, INative value)
        {
            var type = obj.GetType();
            var member = type.GetMembers().FirstOrDefault(n => n.GetCustomAttribute<ShowAsAttribute>()?.Text == name);
            if (member == null) return null;
            if (obj is Objects.Object nObj)
            {
                nObj.SetValue(name, value);
                return value;
            }
            switch (member)
            {
                case PropertyInfo propertyInfo when propertyInfo.CanWrite:
                    propertyInfo.SetValue(obj, value);
                    return propertyInfo.GetValue(obj);

                case FieldInfo fieldInfo when !fieldInfo.IsLiteral:
                    fieldInfo.SetValue(obj, value);
                    return fieldInfo.GetValue(obj);
            }

            return null;
        }

        public static PropertyData GetProperty(IAccessible obj, string name) => new PropertyData(name, GetMember(obj, name).ToNative(obj), obj);
        public static PropertyData SetProperty(IAccessible obj, string name, INative value) => new PropertyData(name, SetMember(obj, name, value).ToNative(obj), obj);

        public static Bool CompareEquality(INative a, string op, INative b)
        {
            return op switch
            {
                "==" => a.Equals(b),
                "!=" => !a.Equals(b),
                "<" => a.Lesser(b),
                "<=" => a.Lesser(b) || a.Equals(b),
                ">" => a.Greater(b),
                ">=" => a.Greater(b) || a.Equals(b),
                _ => false
            };
        }
    }
}