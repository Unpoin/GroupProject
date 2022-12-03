using MetroFramework.Forms;
using MetroFramework;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PcsFileServer
{
    public partial class AutorizationForm : MetroForm 
    {
        public AutorizationForm()
        {
            try
            {
                InitializeComponent();
                this.Show();
                PassPictureBox.Image = Properties.Resources.eyePurple;
                LoginTextBox.Text = Properties.Settings.Default.Login;
                PasswordTextBox.Text = Properties.Settings.Default.Password;
            }
            catch(Exception) { }
        }
        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }
        private void LogicAutorize(ftpuser user)
        {
            try
            {
                Properties.Settings.Default.ionicZlibPackingName = Convert.ToString(user.userid + ".zip");
                Properties.Settings.Default.Save();
                if (!File.Exists(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServer.zip")))
                {
                    IonicZipHelper.CreateArchive(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServer.zip"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось создать архив");
            }
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
        }
        private bool GetUser()
        {
            try
            {
                ApplicationContext context = new ApplicationContext(ApplicationContext.StrConnection());
                var user = context.ftpuser.AsNoTracking().FirstOrDefault(u => u.userid == LoginTextBox.Text || u.email == LoginTextBox.Text);
                if (user == null || user.passwd != PasswordTextBox.Text)
                {
                    user = null;
                    MessageBox.Show("Неправильно введены данные, попробуйте снова!");
                    return false;
                }
                else
                {
                    PcsUser.CurrentUser = user;
                    LogicAutorize(user);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не подключения к серверу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        static public bool checkAutorize;
        async Task GetUserAsync()
        {
            //IntroPictureBox.Dock = DockStyle.Fill;
            //IntroPictureBox.Visible = true;
            try
            {
                Hide();
                var form = new IntroForm();
                form.Show();
                await Task.Run(() =>
                {
                    if (GetUser())
                        checkAutorize = true;
                    else
                        checkAutorize = false;
                });
                form.Close();
                Show();
            }
            catch(Exception)
            {
                Show();
            }
            //IntroPictureBox.Dock = DockStyle.None;
            //IntroPictureBox.Visible = false;
        }
        private void GoToMain()
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
        }

        static public bool OfflineChecker;
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            if (OfflineToggle.Checked)
            {
                OfflineChecker = true;
                Properties.Settings.Default.ionicZlibPackingName = Convert.ToString("offline.zip");
                Properties.Settings.Default.Save();
                if (!File.Exists(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServerOffline.zip")))
                {
                    IonicZipHelper.CreateArchive(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServerOffline.zip"));
                }
                GoToMain();
            }
            else
            {
                OfflineChecker = false;
                await GetUserAsync();
                if (checkAutorize == true)
                {
                    GoToMain();
                }
            }
        }

        private void RecoverPasswordButton_Click(object sender, EventArgs e)
        {
            RecoverForm recoverForm = new RecoverForm();
            //this.Hide();
            recoverForm.ShowDialog();
            //this.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            Hide();
            bool done = false;
            ThreadPool.QueueUserWorkItem((x) =>
            {
                using (var introForm = new IntroForm())
                {
                    introForm.Show();
                    while (!done)
                        Application.DoEvents();
                    introForm.Close();
                }
            });
            Thread.Sleep(2500); 
            done = true;
            Show();
            this.components.SetStyleDark(this);
            RememberToggle.Checked = Properties.Settings.Default.IsRemember;
        }
        private void RememberToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRemember = RememberToggle.Checked;
            Properties.Settings.Default.Save();
        }

        private void AboutTile_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm();
            info.ShowDialog();
        }

        private void PassPictureBox_Click(object sender, EventArgs e)
        {
            if(PasswordTextBox.PasswordChar=='*')
            {
                PasswordTextBox.PasswordChar = '\0';
                PassPictureBox.Image = Properties.Resources.eye_crossedPurple;
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                PassPictureBox.Image = Properties.Resources.eyePurple;
            }
        }

        private void GuideTile_Click(object sender, EventArgs e)
        {
            GuideForm form = new GuideForm();
            form.ShowDialog();
        }
    }
}