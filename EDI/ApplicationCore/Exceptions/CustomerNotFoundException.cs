using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(int customerid) : base($"No Invoice found with ID: {customerid}")
        {
        }

        protected CustomerNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public CustomerNotFoundException(string message) : base(message)
        {
        }

        public CustomerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
