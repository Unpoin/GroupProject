using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System.Data.Entity;

namespace PcsFileServer
{
    //указание типа конфигурации БД для подключения
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    //класс для подключения к БД
    public class ApplicationContext:DbContext
    {
        static public string StrConnection()
        {
            //создание строки подключения с указанием свойств
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Database = "ftp";
            builder.UserID = "proftpd";
            builder.Password = "unpoin1337";
            builder.Server = "25.56.104.182";
            builder.PersistSecurityInfo = true;
            builder.CharacterSet = "utf8";
            builder.SslMode = MySqlSslMode.Disabled;
            return builder.ConnectionString;
        }
        //поле для реалиазации подключения к БД
        public ApplicationContext(string conStr) : base(new MySqlConnection(conStr), true)
        { }
        //модель пользователя для подключения
        public DbSet<ftpuser> ftpuser { get; set; }
    }
}
