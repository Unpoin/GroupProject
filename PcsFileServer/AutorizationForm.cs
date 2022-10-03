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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                //if (passwordTextBox.Text == "Admin" && loginTextBox.Text == "Admin")
                //{
                //    MessageBox.Show($"Здраствуйте, администратор, {loginTextBox.Text}");
                //    AdministrationForm administration = new AdministrationForm();
                //    this.Hide();
                //    administration.ShowDialog();
                //    this.Close();
                //}
                var user = Core.Context.Users.AsNoTracking().FirstOrDefault(u => u.Login == LoginTextBox.Text || u.Email == LoginTextBox.Text);
                if (user == null || user.Password != PasswordTextBox.Text )
                {

                    user = null;
                    MessageBox.Show("Неправильно введены данные, попробуйте снова!");
                    return;
                }
                MessageBox.Show("Добро пожаловать!");
                PcsUser.CurrentUser = user;
                MainForm main= new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Close();
                //if (user.Role == "Manager")
                //{
                //    MessageBox.Show($"Здраствуйте, менеджер, {loginTextBox.Text}");
                //    ManagerForm manager = new ManagerForm();
                //    this.Hide();
                //    manager.ShowDialog();
                //    this.Close();
                //}
                //if (user.Role == "User")
                //{
                //    MessageBox.Show($"Здраствуйте, {loginTextBox.Text}");
                //    MarketForm market = new MarketForm();
                //    this.Hide();
                //    market.ShowDialog();
                //    this.Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }
    }
}






