using System;
using System.Runtime.Serialization;

namespace Drankautomaat
{
    [Serializable]
    internal class OnvoldoendeBekersException : Exception
    {
        public OnvoldoendeBekersException()
        {
        }

        public OnvoldoendeBekersException(string message) : base(message)
        {
        }

        public OnvoldoendeBekersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OnvoldoendeBekersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}