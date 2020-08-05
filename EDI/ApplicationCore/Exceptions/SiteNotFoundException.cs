using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class SiteNotFoundException : Exception
    {
        public SiteNotFoundException(int siteid) : base($"No Site found with ID: {siteid}")
        {
        }

        protected SiteNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public SiteNotFoundException(string message) : base(message)
        {
        }

        public SiteNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
