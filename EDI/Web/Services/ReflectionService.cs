using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Web.Interfaces;

namespace EDI.Web.Services
{
    public class ReflectionService : IReflectionService
    {
        public void SetFieldValue(object obj, string fieldName, string value)
        {
            obj.GetType().GetProperty(fieldName).SetValue(obj, value);
        }

        public string GetFieldValue(object obj, string fieldName)
        {
            string value = (string)obj.GetType().GetProperty((fieldName)).GetValue(obj);
            return value;
        }

    }
}
