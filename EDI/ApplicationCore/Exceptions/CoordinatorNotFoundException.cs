using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class CoordinatorNotFoundException : Exception
    {
        public CoordinatorNotFoundException(int coordinatorid) : base($"No Coordinator found with ID: {coordinatorid}")
        {
        }

        protected CoordinatorNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public CoordinatorNotFoundException(string message) : base(message)
        {
        }

        public CoordinatorNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
