using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    sealed class Core
    {
        private static PcsFileServerEntities1 context;
        public static PcsFileServerEntities1 Context
        {
            get => context ?? (context = new PcsFileServerEntities1());
        }
        public static string Server
        {
            get => Properties.Settings.Default.server;
            set
            {
                Properties.Settings.Default.server = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Database
        {
            get => Properties.Settings.Default.database;
            set
            {
                Properties.Settings.Default.database = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Login
        {
            get => Properties.Settings.Default.loginDB;
            set
            {
                Properties.Settings.Default.loginDB = value;
                Properties.Settings.Default.Save();
            }
        }
        public static string Password
        {
            get => Properties.Settings.Default.passwordDB;
            set
            {
                Properties.Settings.Default.passwordDB = value;
                Properties.Settings.Default.Save();
            }
        }
        public static void ResetConnection()
        {
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = Server;
            sqlConnection.InitialCatalog = Database;
            sqlConnection.UserID = Login;
            sqlConnection.Password = Password;
            Context.Database.Connection.ConnectionString = sqlConnection.ConnectionString;
        }
    }
}
