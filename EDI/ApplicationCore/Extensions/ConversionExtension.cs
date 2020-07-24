using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Extensions
{
    public static class ConversionExtension
    {
        public static string ToYesNoString(this bool value)
        {
            return value ? "yes" : "no";
        }
    }
}
