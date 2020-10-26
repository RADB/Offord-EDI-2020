using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class LinkNotFoundException : Exception
    {
        public LinkNotFoundException(int linkid) : base($"No Link found with ID: {linkid}")
        {
        }

        protected LinkNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public LinkNotFoundException(string message) : base(message)
        {
        }

        public LinkNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
