using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Interfaces
{
    interface IMathService
    {
        int GetRandomPercent(int minimum, int maximum);
        int GetRandomNumber(int minimum, int maximum);
        int GetPercent(int numerator, int denominator);
    }
}
