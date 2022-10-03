using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    public static class PcsUser
    {
        private static User currentUser;

        public static User CurrentUser
        {
            get => currentUser;
            set => currentUser = value;
        }

    }
}
