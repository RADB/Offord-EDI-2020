using System;
using EDI.ApplicationCore.Entities;

namespace EDI.ApplicationCore.Specifications
{
    public class ConfigurationFilterSpecification : BaseSpecification<SystemConfigurations>
    {
        public ConfigurationFilterSpecification(string fieldname)
            : base(i => i.FieldName.ToLower().Trim() == fieldname.Trim().ToLower())
        {
        }

        public ConfigurationFilterSpecification(string fieldname, int id)
            : base(i => i.FieldName.ToLower().Trim() == fieldname.Trim().ToLower() && i.Id != id)
        {
        }
    }
}
