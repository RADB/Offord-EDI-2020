using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class ProvinceNotFoundException : Exception
    {
        public ProvinceNotFoundException(int provinceid) : base($"No Province found with ID: {provinceid}")
        {
        }

        protected ProvinceNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public ProvinceNotFoundException(string message) : base(message)
        {
        }

        public ProvinceNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
