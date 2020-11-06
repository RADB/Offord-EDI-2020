using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class LookupSetNotFoundException : Exception
    {
        public LookupSetNotFoundException(int lookupsetid) : base($"No LookupSet found with ID: {lookupsetid}")
        {
        }

        protected LookupSetNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public LookupSetNotFoundException(string message) : base(message)
        {
        }

        public LookupSetNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
