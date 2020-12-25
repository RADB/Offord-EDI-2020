using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    interface IReflectionService
    {
        void SetFieldValue(object obj, string fieldName, string value);

        string GetFieldValue(object obj, string fieldName);

    }
}
