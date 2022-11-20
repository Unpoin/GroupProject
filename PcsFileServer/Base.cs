using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    public static class Base
    {
        public static string ConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
            }
        }

        public static string ConnectionMethod
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["ConnectionMethod"];
            }
        }

        public static string strConnect
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString;
            }
        }
    }
}
