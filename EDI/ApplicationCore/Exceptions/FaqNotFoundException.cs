using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class FaqNotFoundException : Exception
    {
        public FaqNotFoundException(int faqid) : base($"No Faq found with ID: {faqid}")
        {
        }

        protected FaqNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public FaqNotFoundException(string message) : base(message)
        {
        }

        public FaqNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
