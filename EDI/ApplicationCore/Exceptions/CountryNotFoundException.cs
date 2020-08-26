using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class CountryNotFoundException : Exception
    {
        public CountryNotFoundException(int countryid) : base($"No Country found with ID: {countryid}")
        {
        }

        protected CountryNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public CountryNotFoundException(string message) : base(message)
        {
        }

        public CountryNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
