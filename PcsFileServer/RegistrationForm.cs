using MetroFramework.Controls;
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
            
                try
                {
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
                    && (CapthaTextBox.Text == CapthaHandler.Text)
                    )
                {
                    //создание нового пользователя
                    ftpuser newUser = new ftpuser()
                    {
                        //указание полей для пользователя из полей ввода на форме
                        name = UserNameTextBox.Text,
                        userid = LoginTextBox.Text,
                        passwd = PasswordTextBox.Text,
                        email = MailTextBox.Text,
                        role = "user",
                        phone = PhoneMaskedTextBox.Text,
                        homedir = $"/srv/{LoginTextBox.Text}"
                    };
                    //добавление нового пользователя в контекст
                    context.ftpuser.Add(newUser);
                    //сохранение изменнений
                    context.SaveChanges();
                    MessageBox.Show("Регистрация успешна");
                    this.Close();
                }
                else
                    {
                    string message = "";
                    if (String.IsNullOrEmpty(LoginTextBox.Text) || !(LoginTextBox.Text.Length > 5) || !(LoginTextBox.Text.Length < 50))
                    {
                        message += "Логин не введен или введен некорректно!\n";
                    }
                    if (String.IsNullOrEmpty(PasswordTextBox.Text) || !Regex.IsMatch(PasswordTextBox.Text, regPassword))
                    {
                        message += "Пароль не введен или введен некорректно!\n";
                    }
                    if (String.IsNullOrEmpty(MailTextBox.Text) || !Regex.IsMatch(MailTextBox.Text, regMail))
                    {
                        message += "Почта не введена или введена некорректно!\n";
                    }
                    if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                    {
                        message += "Пароли не совпадают!\n";
                    }
                    if(CapthaTextBox.Text != CapthaHandler.Text)
                    {
                        message += "Неверно введена каптча!\n";
                    }
                    CapthaTextBox.Text = "";
                    CaptchaPictureBox.Image = CapthaHandler.CreateImage(200, 70);
                    MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Нет подключения к серверу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            MetroTextBox TB = (MetroTextBox)sender;
            int VisibleTime = 3000; 

            ToolTip tt = new ToolTip();
            tt.Show("Пароль должен содержать хотя бы одну заглавную букву и цифру, длина не менее 8 символов!", TB, 0, -20, VisibleTime);
        }

        private void MailTextBox_Enter(object sender, EventArgs e)
        {
            MetroTextBox TB = (MetroTextBox)sender;
            int VisibleTime = 3000; 

            ToolTip tt = new ToolTip();
            tt.Show("Почта должна быть следующего вида имя_пользователя@имя_домена (например somebody@example.com)", TB, 0, -20, VisibleTime);
        }
    }
}
