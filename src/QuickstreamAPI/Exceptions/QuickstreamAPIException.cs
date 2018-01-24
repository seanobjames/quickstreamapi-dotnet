using System;

namespace QuickstreamAPI.Exceptions
{
    public class QuickstreamAPIException : Exception
    {
        public QuickstreamAPIException(string message) : base(message) {}
        public QuickstreamAPIException() : base() {}
    }
}