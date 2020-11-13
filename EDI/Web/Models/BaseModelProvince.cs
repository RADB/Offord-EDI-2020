using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.Web.Models
{
    public class BaseModelProvince:BaseModel
    {
        public bool Alberta { get; set; }
        public bool BritishColumbia { get; set; }
        public bool Manitoba { get; set; }
        public bool NewBrunswick { get; set; }
        public bool NewfoundlandandLabrador { get; set; }
        public bool NovaScotia { get; set; }
        public bool Nunavut { get; set; }
        public bool Ontario { get; set; }
        public bool PrinceEdwardIsland { get; set; }
        public bool Quebec { get; set; }
        public bool Saskatchewan { get; set; }
        public bool YukonTerritory { get; set; }
        public bool NorthwestTerritories { get; set; }

        public int YearID { get; set; }
    }
}
