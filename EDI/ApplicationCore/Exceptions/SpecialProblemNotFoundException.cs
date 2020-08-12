using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class SpecialProblemNotFoundException : Exception
    {
        public SpecialProblemNotFoundException(int spid) : base($"No Special Problem found with ID: {spid}")
        {
        }

        protected SpecialProblemNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public SpecialProblemNotFoundException(string message) : base(message)
        {
        }

        public SpecialProblemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
