﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class UserSettings
    {
        //public int Id { get; set; } 
        public string UserName { get; set; }

        public string UserID { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsAuthenticated { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsTeacher { get; set; }

        public bool IsCoordinator { get; set; }

        public string Language { get; set; }
        public bool Validation { get; set; }

        public string Province { get; set; }

        public int TeacherId { get; set; }

        public int YearId { get; set; }

        public bool RadioLabels { get; set; }

        public string LabelFonts { get; set; }

        public string CurrentURL { get; set; }

        public string BackURL { get; set; }

        public bool RequiredNaviBack { get; set; }
    }
}
