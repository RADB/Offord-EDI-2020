using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class SchoolNotFoundException : Exception
    {
        public SchoolNotFoundException(int schoolid) : base($"No School found with ID: {schoolid}")
        {
        }

        protected SchoolNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public SchoolNotFoundException(string message) : base(message)
        {
        }

        public SchoolNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
