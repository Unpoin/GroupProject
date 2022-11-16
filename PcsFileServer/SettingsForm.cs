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
        public void SavePath()
        {
            try
            {
                if (Directory.Exists(PathTextBox.Text))
                {
                    Properties.Settings.Default.pathToSave = PathTextBox.Text;
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
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = dialog.SelectedPath;
            }
        }

        private void SavePathButton_Click(object sender, EventArgs e)
        {
            SavePath();
        }
    }
}
