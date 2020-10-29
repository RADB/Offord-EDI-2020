using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Models
{
    public class LanguageSettings
    {
        public IEnumerable<TranslationItemViewModel> Translations { get; set; }
    }
}
