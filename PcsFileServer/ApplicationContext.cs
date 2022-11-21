﻿using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Text;

namespace PcsFileServer
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationContext:DbContext
    {
        
        static public string StrConnection()
        {
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
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Build();
        //    base.OnModelCreating(modelBuilder);
        //}
        public ApplicationContext(string conStr) : base(new MySqlConnection(conStr), true)
        { }
        public DbSet<ftpuser> ftpuser { get; set; }

    }
}
