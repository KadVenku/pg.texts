using System;
using System.Runtime.Serialization;

namespace pg.texts.exception
{
    public class TextProviderNotInitialisedException : Exception
    {
        public TextProviderNotInitialisedException()
        {
        }

        public TextProviderNotInitialisedException(string message) : base(message)
        {
        }

        public TextProviderNotInitialisedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TextProviderNotInitialisedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}