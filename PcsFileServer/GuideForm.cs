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
    public partial class GuideForm : MetroForm
    {
        public GuideForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
            GuideWebBrowser.AllowWebBrowserDrop = false;
            GuideWebBrowser.Url = new Uri(@"C:\Users\Тома\Documents\GitHub\GroupProject\guide.html");
        }
    }
}
