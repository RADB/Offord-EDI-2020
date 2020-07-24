using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class RoleItemViewModel
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Users { get; set; }
    }
}
