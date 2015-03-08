namespace MediaPlayer.Exceptions

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidMediaException : Exception, ISerializable
    {
        public InvalidMediaException() 
            : base()
        {
        }

        public InvalidMediaException(string message) 
            : base(message)
        {
        }

        public InvalidMediaException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected InvalidMediaException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
