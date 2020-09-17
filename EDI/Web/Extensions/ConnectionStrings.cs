using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Web.Extensions
{
    public static class ConnectionStrings
    {
        public static string ServiceConnection()
        {
            return "Server=.;Integrated Security=true;Initial Catalog=EDI.Service;";
        }
    }
}
