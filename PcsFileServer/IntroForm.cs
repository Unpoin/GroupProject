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
        private BackgroundWorker worker = new BackgroundWorker();
        public event DoWorkEventHandler DoWork
        {
            add { worker.DoWork += value; }
            remove { worker.DoWork += value; }
        }
        public RunWorkerCompletedEventHandler OnWorkCompleted { get; set; }
        public IntroForm()
        {
            this.worker.RunWorkerCompleted += OnWorkCompleted;
            InitializeComponent();
        }
        public void Run()
        {
            this.worker.RunWorkerAsync();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
