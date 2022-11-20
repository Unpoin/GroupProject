
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcsFileServer
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    string connectionString = "database=ftp;user id=proftpd;password=unpoin1337;server=25.56.104.182;port=3306";
            //    using (MySqlConnection connect = new MySqlConnection(connectionString))
            //    {
                    ////connect.Open();
                    ApplicationContext context = new ApplicationContext();
                    var data = context.Users.Select(u => u.email).ToList();
                    dataGridView1.DataSource = data;
            //    }
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            ////MessageBox.Show(ApplicationContext.StrConnection());
        }

    }
}
