using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.ApplicationCore.Entities;

namespace EDI.Web.Interfaces
{
    interface IReflectionService
    {
        void SetFieldValue(object obj, string fieldName, string value);

        void SetFieldValue(Teacher data, string entityName, string fieldName, string value);

        string GetFieldValue(object obj, string fieldName);

        string GetFieldValue(Teacher data, string entityName, string fieldName);
        string GetChildFieldValue(Child data, string entityName, string fieldName);

        //object GetEntity(Teacher data, string entityName);

    }
}
