using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace PcsFileServer
{
    public partial class GuideForm : MetroForm
    {
        public GuideForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
            try
            {
                GuideWebBrowser.AllowWebBrowserDrop = false;
                string curDir = Directory.GetCurrentDirectory();
                this.GuideWebBrowser.Url = new Uri(String.Format("file:///{0}/guide.html", curDir));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
