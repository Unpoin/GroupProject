using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PcsFileServer
{
    public partial class InformationForm : MetroForm
    {
        public InformationForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.Image = Properties.Resources.logo;
        }

        private void OkTile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
