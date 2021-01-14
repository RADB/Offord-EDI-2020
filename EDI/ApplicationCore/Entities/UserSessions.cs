using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    [Table("UserSessions", Schema = "dbo")]
    public class UserSessions : BaseEntity
    {
        public string FieldName { get; set; }

        public string FieldValue { get; set; }

        public string UserID { get; set; }

        public byte[] FieldObject { get; set; }
    }
}
