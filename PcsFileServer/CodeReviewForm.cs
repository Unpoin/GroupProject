using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace PcsFileServer
{
    public partial class CodeReviewForm : MetroForm
    {
        private string email;
        public CodeReviewForm(string email)
        {
            this.components.SetStyleDark(this);
            InitializeComponent();
            this.email = email;
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            int codeFromEmail;
            RecoverForm.emailCodes.TryGetValue(email, out codeFromEmail);
            int codeFromForm = Int32.Parse(CodeTextBox.Text);
            if (codeFromEmail == codeFromForm)
            {
                MessageBox.Show("Вы ввели правильный код");
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный код");
            }
        }
    }
}

