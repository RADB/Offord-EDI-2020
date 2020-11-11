using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Data
{
    public class Enumerations
    {
        enum Orientation : int
        {
            Vertical = 1,
            Horizontal = 2
        }

        enum InputType: int
        {
            SectionHeader =1,
            QuestionHeader = 2,
            Header =3,
            Text=4,
            Date=5,
            Checkbox=6,
            RadioButtons=7,
            NumberBox=8,
            TextArea=9
        }

    }
}
