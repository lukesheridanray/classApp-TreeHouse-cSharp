﻿using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class OutOfBoundException : Exception
    {
        public OutOfBoundException()
        {
        }

        public OutOfBoundException(string message) : base(message)
        {
        }

        public OutOfBoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OutOfBoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}