using System;
using System.Collections.Generic;
using System.Text;
using EDI.ApplicationCore.Entities;


namespace EDI.ApplicationCore.Specifications
{
    public class FormFilterSpecification : BaseSpecification<FormConfigurations>
    {
        public FormFilterSpecification(string formname, string fieldname, int order)
            : base(i => i.FormName.ToLower().Trim() == formname.ToLower().Trim() && i.FieldName.ToLower().Trim() == fieldname.ToLower().Trim() && i.Order == order)
        {
        }
    }
}
