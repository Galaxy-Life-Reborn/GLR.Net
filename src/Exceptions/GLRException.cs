using System;

namespace GLR.Net.Exceptions
{
    public class GLRException : Exception
    {
        public GLRException() : base() { }
        public GLRException(string message) : base(message) { }
    }
}
