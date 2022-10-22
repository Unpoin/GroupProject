using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PcsFileServer
{
    public partial class SettingsForm : MetroForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.components.SetStyleDark(this);
        }
        string path = Properties.Settings.Default.pathToSave;
        public void SaveFolder()
        {
            //Доделать сохранение пути хранения(его выбор "..." )
            //Исправить везде пути к архиву на свойства проекта pathToSave
            //на авторизациии при создании архива добавлять путь в переменную свойствах проекта
            try
            {
                if (Directory.Exists(PathTextBox.Text))
                {
                    Properties.Settings.Default.passwordDB = PathTextBox.Text;
                    Properties.Settings.Default.Save();
                    if (!File.Exists($@"{path}\PcsFileServer.zip"))
                    {
                        IonicZipHelper.CreateArchive(Path.Combine(PathTextBox.Text, "PcsFileServer.zip"));
                    }
                    else
                    {
                        File.Move(Path.Combine(path, "PcsFileServer.zip"), Path.Combine(PathTextBox.Text, "PcsFileServer.zip"));
                    }
                    MessageBox.Show("Путь хранения сохранен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AutorizationForm form = new AutorizationForm();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Папка отсутствует!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePathButton_Click(object sender, EventArgs e)
        {

        }
    }
}
