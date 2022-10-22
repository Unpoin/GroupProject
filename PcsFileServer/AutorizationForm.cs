using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using Ionic.Zip;

namespace PcsFileServer
{
    public partial class AutorizationForm : MetroForm 
    {
        public AutorizationForm()
        {
            try
            {
                InitializeComponent();
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
        private static string CreateEmptyDirectory()
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "YourArchive");
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            //else
            //{
            //    var files = Directory.GetFiles(directory);
            //    foreach (var file in files)
            //    {
            //        File.Delete(file);
            //    }
            //}
            return directory;
        }
        static long GetDirectorySize(string path)
        {
            var a = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            return a.Select(name => new FileInfo(name)).Select(info => info.Length).Sum();
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
                try
                {
                    Properties.Settings.Default.ionicZlibPackingName = Convert.ToString(user.Login + ".zip");
                    Properties.Settings.Default.Save();
                    if (!File.Exists(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServer.zip")))
                    {
                        IonicZipHelper.CreateArchive(Path.Combine(Properties.Settings.Default.pathToSave, "PcsFileServer.zip"));
                    }
                    //bool isArchiveExist = false;
                    //using (var zipFile = ZipFile.Read(Path.Combine("C:\\Users\\Miho\\Documents\\Temp", "PcsFileServer.zip")))
                    //{
                    //    isArchiveExist = zipFile.ContainsEntry("PcsFileServer.zip");
                    //}
                    //if (!isArchiveExist)
                    //{
                    //    IonicZipHelper.CreateArchive(Path.Combine("C:\\Users\\Miho\\Documents\\Temp", "PcsFileServer.zip"));
                    //}
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
            Thread.Sleep(5000); 
            done = true;
            Show();

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
        }
        private void RememberToggle_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsRemember = RememberToggle.Checked;
            Properties.Settings.Default.Save();
        }
    }
}






