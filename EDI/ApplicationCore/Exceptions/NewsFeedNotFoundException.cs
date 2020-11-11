using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class NewsFeedNotFoundException : Exception
    {
        public NewsFeedNotFoundException(int newsFeedid) : base($"No NewsFeed found with ID: {newsFeedid}")
        {
        }

        protected NewsFeedNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public NewsFeedNotFoundException(string message) : base(message)
        {
        }

        public NewsFeedNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
