using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    public static class PcsUser
    {
        private static ftpuser currentUser;

        public static ftpuser CurrentUser
        {
            get => currentUser;
            set => currentUser = value;
        }

    }
}
