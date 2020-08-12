using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class YearNotFoundException : Exception
    {
        public YearNotFoundException(int yearid) : base($"No Year found with ID: {yearid}")
        {
        }

        protected YearNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public YearNotFoundException(string message) : base(message)
        {
        }

        public YearNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
