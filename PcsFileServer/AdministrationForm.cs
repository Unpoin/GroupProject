using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace PcsFileServer
{
    public partial class AdministrationForm:MetroForm 
    {
        public AdministrationForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
        }

        private void AboutTile_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm();
            info.ShowDialog();
        }

        private void GuideTile_Click(object sender, EventArgs e)
        {
            //guideform
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
            ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
            var data = context.ftpuser
                    .Select(t => new
                    {
                        t.userid,
                        t.passwd,
                        t.name,
                        t.email,
                        t.role,
                        t.phone
                    });
            UsersDataGrid.DataSource = data.ToList();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UsersDataGrid.SelectedRows)
            {
                //удалить пользователя
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
