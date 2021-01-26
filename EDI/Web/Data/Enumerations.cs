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
            Header = 9,
            QuestionHeader = 10,
            GroupHeader = 11,
            Toggle = 12,
            NumberBoxDouble = 13,
            Hidden = 14
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

        public enum Genders: int
        {
            Male=1,
            Female=2
        }

        public enum ImportStatus: int
        {
            Imported = 1,
            Processed = 2
        }

        public enum ChildStatus: int 
        {            
            New = 2,
            InProgress = 1,
            Complete = 3,
            Locked = 4
        }
        public enum TeacherStatus : int
        {
            New = 4,
            InProgress = 3,
            Complete = 2,
            Locked = 1
        }
        public enum FileImportStatus : int
        {
            Imported = 1,
            Processed = 2,
            Duplicate = 3,
            InvalidProvince = 4
        }
    }
}
