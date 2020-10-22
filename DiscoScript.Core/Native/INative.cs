using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DiscoScript.Common;
using DiscoScript.Core.Native.Values;

namespace DiscoScript.Core.Native
{
    [TypeConverter(typeof(NativeConverter))]
    public interface INative
    {
        public static INative operator +(INative a, INative b)
        {
            var aIsNumber = a.Is<Number>(out var aNumber);
            var bIsNumber = b.Is<Number>(out var bNumber);
            var aIsText = a.Is<Text>(out var aText);
            var bIsText = b.Is<Text>(out var bText);

            if (aIsNumber && bIsNumber) return aNumber + bNumber;
            if (aIsText && bIsText) return aText + bText;
            if (aIsText && bIsNumber) return aText + bNumber;
            return Number.NaN;
        }
        
        public static INative operator -(INative a, INative b)
        {
            var aIsNumber = a.Is<Number>(out var aNumber);
            var bIsNumber = b.Is<Number>(out var bNumber);

            if (aIsNumber && bIsNumber) return aNumber - bNumber;
            return Number.NaN;
        }
        
        public static INative operator *(INative a, INative b)
        {
            var aIsNumber = a.Is<Number>(out var aNumber);
            var bIsNumber = b.Is<Number>(out var bNumber);
            var aIsText = a.Is<Text>(out var aText);
            var bIsText = b.Is<Text>(out var bText);

            if (aIsNumber && bIsNumber) return aNumber * bNumber;
            if (aIsText && bIsNumber) return aText * bNumber;
            return Number.NaN;
        }
        
        public static INative operator /(INative a, INative b)
        {
            var aIsNumber = a.Is<Number>(out var aNumber);
            var bIsNumber = b.Is<Number>(out var bNumber);

            if (aIsNumber && bIsNumber) return aNumber / bNumber;
            return Number.NaN;
        }
        
        public bool IsNull() => this is Null;
        public bool IsUndefined() => this is Undefined;

        public Bool ToBool()
        {
            return this switch
            {
                Bool bol => bol,
                Date date => date > 0,
                Null _ => false,
                Undefined _ => false,
                Number number => number > 0,
                Text text => text.Length > 0,
                Objects.Objects.Array array => array.Length > 0,
                _ => true
            };
        }


        public object? GetInternalValue()
        {
            var type = GetType();
            var hasInternal = type.GetInterfaces() .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IInternalValue<>));
            return !hasInternal ? null : type.GetMethod("GetInternalValue")!.Invoke(this, null);
        }
        bool Greater(INative b);
        bool Lesser(INative b);
    }

    public class NativeConverter : TypeConverter
    {
        private static Type[] _validTypes = new[]
        {
            typeof(bool), typeof(DateTime), typeof(TimeSpan),
            typeof(string)
        };
        

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return Helpers.IsNumeric(sourceType) || _validTypes.Contains(sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return value.ToNative();
        }

    }
}