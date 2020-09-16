using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException(int teacherid) : base($"No Teacher found with ID: {teacherid}")
        {
        }

        protected TeacherNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public TeacherNotFoundException(string message) : base(message)
        {
        }

        public TeacherNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
