using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class QuestionnaireNotFoundException : Exception
    {
        public QuestionnaireNotFoundException(int questionnaireid) : base($"No Questionnaire found with ID: {questionnaireid}")
        {
        }

        protected QuestionnaireNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public QuestionnaireNotFoundException(string message) : base(message)
        {
        }

        public QuestionnaireNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
