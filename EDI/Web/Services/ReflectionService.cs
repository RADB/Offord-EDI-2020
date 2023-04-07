using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Web.Interfaces;
using EDI.ApplicationCore.Entities;
//using EDI.Web.Lib;
using EDI.Web.Models;

namespace EDI.Web.Services
{
    public class ReflectionService : IReflectionService
    {

        private UserSettings _UserSettings { get; set; }

        public ReflectionService(UserSettings UserSettings)
        {
            _UserSettings = UserSettings;
        }

        //abstract for generic future use
        public void SetFieldValue(object obj, string fieldName, string value)
        {
            if (value == "")
            {
                obj.GetType().GetProperty(fieldName).SetValue(obj, null);
            }   
            else
            {
                // if null error - be sure to add to entity
                // nullable types must be discovered via Generictype - non nullable through propertytype
                if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.String")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, value);
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.Byte")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, string.IsNullOrEmpty(value) ? null : byte.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.Int16")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, short.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.Int32")
                {
                    //non-nullable
                    obj.GetType().GetProperty(fieldName).SetValue(obj, int.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.Decimal")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, decimal.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.DateTime")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, DateTime.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.FullName == "System.Boolean")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, bool.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Byte")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, string.IsNullOrEmpty(value) ? null : byte.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Int16")
                {
                    obj.GetType().GetProperty(fieldName).SetValue(obj, short.Parse(value));
                }
                else if (obj.GetType().GetProperty(fieldName).PropertyType.GenericTypeArguments[0].FullName == "System.Int32")
                {
                    //nullable
                    obj.GetType().GetProperty(fieldName).SetValue(obj, int.Parse(value));
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
                //if (fieldName =="GenderId")
                //{
                //    Console.WriteLine("Break Here for testing.");
                //}
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
                "Child" => data.Children.Single(),
                _ => null,
            };
        }

        private object GetChildEntity(Child data, string entityName)
        {
            try
            {
                return entityName switch
                {
                    "Questionnaires.Data.Demographics" => data.QuestionnairesDataDemographics.Single(),
                    "Questionnaires.Data.SectionA" => data.QuestionnairesDataSectionAs.Single(),
                    "Questionnaires.Data.SectionB" => data.QuestionnairesDataSectionBs.Single(),
                    "Questionnaires.Data.SectionC" => data.QuestionnairesDataSectionCs.Single(),
                    "Questionnaires.Data.SectionD" => data.QuestionnairesDataSectionDs.Single(),
                    "Questionnaires.Data.SectionE" => data.QuestionnairesDataSectionEs.Single(),
                    //"Questionnaires.Data.TeacherProfile" => data.QuestionnairesDataTeacherProfiles.Single(),
                    //"Child" => data.Children.Single(),
                    _ => null,
                };
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public void SetFieldValue(Teacher data, string entityName, string fieldName, string value)
        {
            var obj = GetEntity(data, entityName);
            SetFieldValue(obj, fieldName, value);

            // update the child table with DOB, Postal and Gender
            if (entityName == "Questionnaires.Data.Demographics" && (fieldName == "Dob" || fieldName == "GenderId" || fieldName =="PostalCode"))
                SetFieldValue(data.Children.First(), fieldName, value);

            // store the teacher data entity changes for saving
            if (!_UserSettings.UseJSON)
                _UserSettings.TeacherData = data;            
        }

        public string GetFieldValue(Teacher data, string entityName, string fieldName)
        {
            var obj = GetEntity(data, entityName);
            var value =  GetFieldValue(obj, fieldName);
            return value;
        }

        public string GetChildFieldValue(Child data, string entityName, string fieldName)
        {
            try
            {
                var obj = GetChildEntity(data, entityName);
                var value = GetFieldValue(obj, fieldName);
                return value;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
