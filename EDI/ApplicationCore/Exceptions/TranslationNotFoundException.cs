using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class TranslationNotFoundException : Exception
    {
        public TranslationNotFoundException(int translationid) : base($"No Translation found with ID: {translationid}")
        {
        }

        protected TranslationNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public TranslationNotFoundException(string message) : base(message)
        {
        }

        public TranslationNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
