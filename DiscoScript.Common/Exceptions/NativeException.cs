using System;

namespace DiscoScript.Common.Exceptions
{
    public class NativeException : Exception
    {
        public CodePosition? Position { get; }
        public NativeException(string message) : base(message)
        {
            
        }

        public NativeException(string message, CodePosition? position) : base(message)
        {
            Position = position;
        }
    }
}