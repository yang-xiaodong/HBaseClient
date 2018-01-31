using System;

namespace Geekbuying.HBaseClient.Tests.Utilities
{
    public class AssertFailedException : Exception
    {
        public AssertFailedException()
        {
        }

        public AssertFailedException(string message) : base(message)
        {
        }

        public AssertFailedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}