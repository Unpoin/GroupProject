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
    }
}
