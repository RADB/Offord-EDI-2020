using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class LookupSetOptionNotFoundException : Exception
    {
        public LookupSetOptionNotFoundException(int lookupsetoptionid) : base($"No LookupSet Option found with ID: {lookupsetoptionid}")
        {
        }

        protected LookupSetOptionNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public LookupSetOptionNotFoundException(string message) : base(message)
        {
        }

        public LookupSetOptionNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
