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
             LoginTextBox.Validating += LoginTextBox_Validating;
            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
        }

        private void UpdateCapthcaButton_Click(object sender, EventArgs e)
        {
            CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            if (CapthaTextBox.Text == CapthaHandler.Text)
            {
                try
                {
                    string regMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
                    string regPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
                    var user = Core.Context.Users.AsNoTracking().FirstOrDefault(u => u.Login == LoginTextBox.Text || u.Email == LoginTextBox.Text);
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
                        User newUser = new User
                        {
                            Name = UserNameTextBox.Text,
                            Login = LoginTextBox.Text,
                            Password = PasswordTextBox.Text,
                            Role = "User",
                            Email = MailTextBox.Text,
                            Phone = PhoneMaskedTextBox.Text
                        };
                        Core.Context.Users.Add(newUser);
                        Core.Context.SaveChanges();
                        MessageBox.Show("Регистрация успешна");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неккоректно введены данные");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Неверно введена каптча");
            }

        }

        private void LoginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                errorProvider1.SetError(LoginTextBox, "Не указан логин!");
            }
            else if (LoginTextBox.Text.Length < 5)
            {
                errorProvider1.SetError(LoginTextBox, "Слишком короткий логин!");
            }
            else if(LoginTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(LoginTextBox, "Слишком длинный логин!");
            }
            else
            {
                errorProvider1.Clear();
            }
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

        private void MailTextBox_Validating(object sender, CancelEventArgs e)
        {
            string regMail = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";
            if (String.IsNullOrEmpty(MailTextBox.Text))
            {
                errorProvider1.SetError(MailTextBox, "Не указана почта!");
            }
            else if (!Regex.IsMatch(MailTextBox.Text, regMail))
            {
                errorProvider1.SetError(MailTextBox, "Некорректная почта!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void PasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            string regPassword = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$";
            
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                errorProvider1.SetError(PasswordTextBox, "Не указан пароль!");
            }
            else if (!Regex.IsMatch(PasswordTextBox.Text, regPassword))
            {
                errorProvider1.SetError(PasswordTextBox, "Некорректный пароль!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
