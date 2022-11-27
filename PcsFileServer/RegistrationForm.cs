using MetroFramework.Forms;
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

namespace PcsFileServer
{
    public partial class RegistrationForm : MetroForm
    {
        
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
            this.components.SetStyleDark(this);
        }
        private void LoginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }
        private void UpdateCapthcaButton_Click(object sender, EventArgs e)
        {
            CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (CapthaTextBox.Text == CapthaHandler.Text)
            {
                //try
                //{
                    ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                    string regMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
                    string regPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
                    var user = context.ftpuser.AsNoTracking().FirstOrDefault(u => u.userid == LoginTextBox.Text || u.email == LoginTextBox.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Логин занят, введите другой");
                        return;
                    }

                    if (!String.IsNullOrEmpty(LoginTextBox.Text)
                        && !String.IsNullOrEmpty(PasswordTextBox.Text)
                        && !String.IsNullOrEmpty(MailTextBox.Text)
                        && PasswordTextBox.Text == ConfirmPasswordTextBox.Text
                        && (LoginTextBox.Text.Length > 5)
                        && (LoginTextBox.Text.Length < 50)
                        && Regex.IsMatch(MailTextBox.Text, regMail)
                        && Regex.IsMatch(PasswordTextBox.Text, regPassword)
                        )
                    {
                    ftpuser newUser = new ftpuser()
                    {
                        name = UserNameTextBox.Text,
                        userid = LoginTextBox.Text,
                        passwd = PasswordTextBox.Text,
                        email = MailTextBox.Text,
                        role = "user",
                        phone = PhoneMaskedTextBox.Text,
                        homedir=$"/srv/{PcsUser.CurrentUser.userid}"
                    };
                        context.ftpuser.Add(newUser);
                        context.SaveChanges();
                        MessageBox.Show("Регистрация успешна");
                        this.Close();
                    }
                    else
                    {
                        CapthaTextBox.Text = "";
                        CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
                        MessageBox.Show("Неккоректно введены данные");
                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            else
            {
                MessageBox.Show("Неверно введена каптча");
            }
        }
    }
}
