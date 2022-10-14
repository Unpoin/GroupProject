using MetroFramework.Forms;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace PcsFileServer
{
    public partial class AutorizationForm : MetroForm 
    {
        public void Intro()
        {
            try
            {
                IntroForm frm = new IntroForm();
                Application.Run(frm);
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }
        public AutorizationForm()
        {
            try
            {//2 Варианта использовать цикл или трид слип ..
                Thread t = new Thread(Intro);
                t.Start();
                //Thread.Sleep(2500);
                InitializeComponent();
                string str = string.Empty;
                for (int i = 0; i < 49000; i++)
                {
                    str += i.ToString();
                }
                t.Abort();
                LoginTextBox.Text = Properties.Settings.Default.Login;
                PasswordTextBox.Text = Properties.Settings.Default.Password;
            }
            catch { }
        }
        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = Core.Context.Users.AsNoTracking().FirstOrDefault(u => u.Login == LoginTextBox.Text || u.Email == LoginTextBox.Text);
                if (user == null || user.Password != PasswordTextBox.Text)
                {

                    user = null;
                    MessageBox.Show("Неправильно введены данные, попробуйте снова!");
                    return;
                }
                MessageBox.Show("Добро пожаловать!");
                PcsUser.CurrentUser = user;
                if (Properties.Settings.Default.IsRemember == true)
                {
                    Properties.Settings.Default.Login = LoginTextBox.Text;
                    Properties.Settings.Default.Password = PasswordTextBox.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Login = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Save();
                }
                MainForm main = new MainForm();
                this.Hide();
                main.ShowDialog();
                this.Close();
                            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            RecoverForm recoverForm = new RecoverForm();
            recoverForm.ShowDialog();   
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            this.components.SetStyleDark(this);
            RememberToggle.Checked = Properties.Settings.Default.IsRemember;
            //try
            //{
            //    SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            //    Core.Server = @"ROMANUS";
            //    Core.Database = @"PcsFileServer";
            //    Core.Login = @"sa";
            //    Core.Password = @"1";
            //    Core.ResetConnection();
            //    Core.Context.Database.Connection.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //Переделать инттро
            //var introForm = new IntroForm();
            //introForm.DoWork += LongRunningOperation;
            //introForm.OnWorkCompleted = (o, args) => MessageBox.Show("Finished!");
            //introForm.Show();
            //introForm.Run(); // should execute LongRunningOperation, method below.
        }
        //private void LongRunningOperation(object sender, DoWorkEventArgs e)
        //{
        //    var introForm = new IntroForm();
        //    introForm.Close();
        //}
        private void RememberToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRemember = RememberToggle.Checked;
            Properties.Settings.Default.Save();
        }
    }
}






