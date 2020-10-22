using System;
using System.Collections;
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
    public static class Extensions
    {
        public static Promise ToPromise(this Task task) => new Promise(task);

        public static INative ToNative(this object? obj, params object?[] args)
        {
            if (Helpers.IsNumeric(obj)) return new Number(Convert.ToDouble(obj));
            if (obj is INative native) return native;
            return obj switch
            {
                null => new Null(),
                string str => new Text(str),
                bool bol => new Bool(bol),
                MethodInfo methodInfo => new Function(methodInfo.GetShowAs(),args.ElementAtOrDefault(0), methodInfo),
                Function.FunctionDelegate del => new Function(del.Method.GetShowAs(), del),
                PropertyInfo prop => prop.GetValue(args.ElementAtOrDefault(0)).ToNative(),
                FieldInfo field => field.GetValue(args.ElementAtOrDefault(0)).ToNative(),
                IEnumerable enumerable => new Objects.Array(enumerable),
                DateTime dateTime => new Date(dateTime),
                TimeSpan timeSpan => new Date(new DateTime().Add(timeSpan)),
                Task task => new Promise(task),
                _ => new Undefined()
            };
        }


        public static T As<T>(this INative native) => native is T tn ? tn : throw new InvalidCastException();

        public static string GetShowAs(this object obj)
        {
            if (obj is MemberInfo memberInfo)
                return (memberInfo.GetCustomAttribute<ShowAsAttribute>()?.Text ?? memberInfo.Name) ?? "";

            var type = obj is Type type1 ? type1 : obj.GetType();
            return (type.GetCustomAttribute<ShowAsAttribute>()?.Text ?? type.Name) ?? "";
        }

        public static bool Is<T>(this object? obj) => obj is T;

        public static bool Is<T>(this object? obj, out T value)
        {
            value = default!;
            if (!(obj is T val)) return false;
            value = val;
            return true;

        }

        public static async Task<INative> GetResult(this Task<ICompletion<INative>> completion) => (await completion).Result;
        public static async Task<T> GetResult<T>(this Task<ICompletion<INative>> completion) where T : INative
        {
            var res = await completion;
            return (T) res.Result;
        }

        public static async Task<T> As<T>(this Task<ICompletion<INative>> completion) where T : ICompletion<INative>
        {
            var res = await completion;
            return (T) res;
        }
        
        public static async Task<ICompletion<INative>> ExecuteAsync(this IEnumerable<Node<INative, Scope>> enumerable, Scope scope)
        {
            ICompletion<INative> last = new Completion(new Undefined());
            foreach (var node in enumerable)
            {
                last = await node.ExecuteAsync(scope);
                if (last is Completion completion && !completion.Continue)
                    return last;
            }

            return last;
        }

        public static Task<INative> ToTask(this INative native) => Task.FromResult(native);
    }
}