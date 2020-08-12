using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class LanguageNotFoundException : Exception
    {
        public LanguageNotFoundException(int languageid) : base($"No School found with ID: {languageid}")
        {
        }

        protected LanguageNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public LanguageNotFoundException(string message) : base(message)
        {
        }

        public LanguageNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
