using System;
using System.Runtime.Serialization;

namespace HardwareStoreApp
{
    [Serializable]
    internal class InvalidLoginDetailsException : Exception
    {
        public InvalidLoginDetailsException()
        {
        }

        public InvalidLoginDetailsException(string message) : base(message)
        {
        }

        public InvalidLoginDetailsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidLoginDetailsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}