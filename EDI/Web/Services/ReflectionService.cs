using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Web.Interfaces;
using EDI.ApplicationCore.Entities;
using EDI.Web.Lib;

namespace EDI.Web.Services
{
    public class ReflectionService : IReflectionService
    {
        //private StateContainer _StateContainer { get; set; }

        //public ReflectionService(StateContainer StateContainer)
        //{
        //    _StateContainer = StateContainer;
        //}

        //abstract for generic future use
        public void SetFieldValue(object obj, string fieldName, string value)
        {
            if (value == "")
            {
                obj.GetType().GetProperty(fieldName).SetValue(obj, null);
            }   
            else
            {
                if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.String")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, value);
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Byte")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, byte.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Int16")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, short.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Decimal")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, decimal.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.DateTime")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, DateTime.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Boolean")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, bool.Parse(value));
                }
                else
                {
                    Console.WriteLine("Set the value of type {0}", obj.GetType().GetProperty(fieldName.Trim()).PropertyType.GenericTypeArguments[0].FullName);
                }
            }

        }

        //abstract for generic future use
        public string GetFieldValue(object obj, string fieldName)
        {
            string value;
            if (obj.GetType().GetProperty(fieldName) == null)
            {
                value = string.Empty;
            }
            else 
            {
                if (obj.GetType().GetProperty(fieldName).GetValue(obj) == null)
                {
                    value = string.Empty;
                }
                else
                { 
                    value = obj.GetType().GetProperty(fieldName).GetValue(obj).ToString(); 
                }
            }            
            
            return value;
        }

        //EDI Specific use
        private object GetEntity(Teacher data, string entityName)
        {
            return entityName switch
            {
                "Questionnaires.Data.Demographics" => data.Children.First().QuestionnairesDataDemographics.Single(),
                "Questionnaires.Data.SectionA" => data.Children.First().QuestionnairesDataSectionAs.Single(),
                "Questionnaires.Data.SectionB" => data.Children.First().QuestionnairesDataSectionBs.Single(),
                "Questionnaires.Data.SectionC" => data.Children.First().QuestionnairesDataSectionCs.Single(),
                "Questionnaires.Data.SectionD" => data.Children.First().QuestionnairesDataSectionDs.Single(),
                "Questionnaires.Data.SectionE" => data.Children.First().QuestionnairesDataSectionEs.Single(),
                "Questionnaires.Data.TeacherProfile" => data.QuestionnairesDataTeacherProfiles.Single(),
                _ => null,
            };
        }

        public void SetFieldValue(Teacher data, string entityName, string fieldName, string value)
        {
            var obj = GetEntity(data, entityName);
            SetFieldValue(obj, fieldName, value);

            //_StateContainer.SetTeacher(data);
        }

        public string GetFieldValue(Teacher data, string entityName, string fieldName)
        {
            var obj = GetEntity(data, entityName);
            var value =  GetFieldValue(obj, fieldName);
            return value;
        }
    }
}
