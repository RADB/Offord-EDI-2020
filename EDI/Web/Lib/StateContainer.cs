using EDI.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Lib
{
    public class StateContainer
    {
        public string Property { get; set; } = "Initial value from StateContainer";

        public string UserName { get; set; }

        public string BackURL { get; set; }

        public string CurrentURL { get; set; }

        public bool OnEnglishSwitchChangeNaviBack { get; set; }

        public Teacher TeacherData { get; set; }

        public event Action OnChange;

        public void SetProperty(string value)
        {
            Property = value;
            NotifyStateChanged();
        }
        public void SetUsername(string value)
        {
            UserName = value;
            NotifyStateChanged();
        }
        public void SetTeacher(Teacher value)
        {
            TeacherData = value;
            NotifyStateChanged();
        }
        public void SetBackURL(string value)
        {
            BackURL = value;
            NotifyStateChanged();
        }
        public void SetCurrentURL(string value)
        {
            CurrentURL = value;
            NotifyStateChanged();
        }
        public void SetEnglishSwitchChangeNaviBack(bool value)
        {
            OnEnglishSwitchChangeNaviBack = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
