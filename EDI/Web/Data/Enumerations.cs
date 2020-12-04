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

        public enum InputTypes : int
        {
            TextArea = 1,
            RadioMatrix = 2,
            RadioButtons = 3,
            NumberBox = 4,
            DatePicker = 5,
            CheckBox = 6,
            SelectBox = 7,
            TextBox = 8,
            Header = 9
        }
        public enum NumericDataTypes : int
        {
            Int32 = 1,
            Double = 2
        }

        public enum Questionnaires: int
        {
            Demographics =0,
            SectionA = 1,
            SectionB=2,
            SectionC=3,
            SectionD=4,
            SectionE=5,
            TeacherProfile=6
        }
    }
}
