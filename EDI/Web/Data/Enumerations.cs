using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Data
{
    public class Enumerations
    {
        public enum Orientations : int
        {
            Vertical = 1,
            Horizontal = 2
        }

        public enum InputTypes: int
        {
            TextArea = 1,
            RadioMatrix =2,
            RadioButtons=3,
            NumberBox =4,
            DatePicker=5,
            CheckBox=6,
            SelectBox=7,
            TextBox=8,
            Header=9
        }

    }
}
