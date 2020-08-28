using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class ConfigurationNotFoundException : Exception
    {
        public ConfigurationNotFoundException(int configurationid) : base($"No Configuration found with ID: {configurationid}")
        {
        }

        protected ConfigurationNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public ConfigurationNotFoundException(string message) : base(message)
        {
        }

        public ConfigurationNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
