using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace PcsFileServer
{
    
    public partial class CodeReviewForm : MetroForm
    {
        public static void KeyCharCheck(object obj, KeyPressEventArgs ev)
        {
            if ((ev.KeyChar >= 'A' && ev.KeyChar <= 'Z') || (ev.KeyChar >= 'a' && ev.KeyChar <= 'z') || (ev.KeyChar >= '0' && ev.KeyChar <= '9') || ev.KeyChar == '_' || ev.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                ev.Handled = true;
            }
        }
        private string email;
        public CodeReviewForm(string email)
        {
            this.components.SetStyleDark(this);
            InitializeComponent();
            this.email = email;
        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            try
            {
                int codeFromEmail;
                RecoverForm.emailCodes.TryGetValue(email, out codeFromEmail);
                string regPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
                int codeFromForm = Int32.Parse(CodeTextBox.Text);
                if (codeFromEmail == codeFromForm)
                {
                    if (String.IsNullOrEmpty(PasswordTextBox.Text) || String.IsNullOrEmpty(ConfirmTextBox.Text))
                    {
                        MessageBox.Show("Не все поля заполнены");
                    }
                    else if (PasswordTextBox.Text != ConfirmTextBox.Text)
                    {
                        MessageBox.Show("Пароли не совпадают");
                    }
                    else if (!Regex.IsMatch(PasswordTextBox.Text, regPassword))
                    {
                        MessageBox.Show("Пароль минимум 8 символов, должен содержать заглавные буквы и цифры");
                    }
                    else
                    {
                        ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                        var user = context.ftpuser.FirstOrDefault(u => u.email == this.email);
                        user.passwd = PasswordTextBox.Text;
                        context.SaveChanges();
                        AutorizationForm form = new AutorizationForm();
                        MessageBox.Show("Пароль успешно изменен");
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильный код");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCharCheck(sender, e);
        }

        private void ConfirmTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyCharCheck(sender, e);
        }
    }
}
