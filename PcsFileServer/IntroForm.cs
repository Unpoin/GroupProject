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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
            timer1.Interval = 25;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntroProgressBar.Increment(1);
            if (IntroProgressBar.Value == 100) timer1.Stop();
        }
    }
}
