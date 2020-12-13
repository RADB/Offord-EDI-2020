using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Exceptions
{
    class QuestionnaireConfigurationNotFoundException : Exception
    {
        public QuestionnaireConfigurationNotFoundException(int questionnaireConfigurationid) : base($"No Questionnaire Configuration found with ID: {questionnaireConfigurationid}")
        {
        }

        protected QuestionnaireConfigurationNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }

        public QuestionnaireConfigurationNotFoundException(string message) : base(message)
        {
        }

        public QuestionnaireConfigurationNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
