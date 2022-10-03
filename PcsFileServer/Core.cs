using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    sealed class Core
    {
        private static PcsFileServerEntities context;
        public static PcsFileServerEntities Context
        {
            get => context ?? (context = new PcsFileServerEntities());
        }
        static string server = @"LAPTOP-G1BKDD1R\\SQLEXPRESS";
        static string database = "PcsFileServer";
        static string login = "sa";
        static string password= "1";
        public static string Server { get => server; set => server = value; }
        public static string Database { get => database; set => database = value; }
        public static string Login { get => login; set => login = value; }
        public static string Password { get => password; set => password = value; }

    }
}
