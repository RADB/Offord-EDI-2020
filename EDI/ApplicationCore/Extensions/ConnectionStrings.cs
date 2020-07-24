using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.ApplicationCore.Extensions
{
    public static class ConnectionStrings
    {
        public static string ServiceConnection()
        {
            return "Server=.;Integrated Security=true;Initial Catalog=EDI.Service;";
        }
    }
}
