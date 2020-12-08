using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class InputTypeItemViewModel : BaseModel
    {
        public int YearId { get; set; }
        public short? Ediyear { get; set; }
        public string English { get; set; }
        public string French { get; set; }
    }
}
