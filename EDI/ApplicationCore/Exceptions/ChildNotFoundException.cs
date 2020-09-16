using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class ChildNotFoundException : Exception
    {
        public ChildNotFoundException(int childid) : base($"No Child found with ID: {childid}")
        {
        }

        protected ChildNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public ChildNotFoundException(string message) : base(message)
        {
        }

        public ChildNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
