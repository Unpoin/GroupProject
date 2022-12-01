using Ionic.Zip;
using MetroFramework.Controls;
using MetroFramework.Forms;
using PcsFileServer.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PcsFileServer
{
    public partial class MainForm : MetroForm
    {
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColorTable()) { }
        }
        private class MyColorTable : ProfessionalColorTable
        {
            Color mainColor = Color.Black;
            Color gradColor = Color.Purple;
            public override Color MenuItemSelected
            {
                get { return gradColor; }
            }

            public override Color ToolStripContentPanelGradientBegin
            {
                get { return mainColor; }
            }

            public override Color MenuItemBorder
            {
                get { return mainColor; }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return gradColor; }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return gradColor; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return mainColor; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return mainColor; }
            }

            public override Color MenuBorder
            {
                get { return mainColor; }
            }
            public override Color ToolStripBorder
            {
                get { return mainColor; }
            }
            public override Color ToolStripDropDownBackground
            {
                get { return mainColor; }
            }
            public override Color ToolStripGradientBegin
            {
                get { return mainColor; }
            }
            public override Color ToolStripGradientEnd
            {
                get { return mainColor; }
            }
            public override Color ToolStripGradientMiddle
            {
                get { return mainColor; }
            }
            public override Color ToolStripContentPanelGradientEnd
            {
                get { return mainColor; }
            }

            public override Color ToolStripPanelGradientBegin
            {
                get { return mainColor; }
            }

            public override Color ToolStripPanelGradientEnd
            {
                get { return mainColor; }
            }
        }
        public void CreateArchive()
        {
            try
            {
                bool isZipExist = false;
                using (var zipFile = ZipFile.Read(Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip")))
                {
                    isZipExist = zipFile.ContainsEntry($"{PcsUser.CurrentUser.userid}.zip");
                }
                if (!isZipExist)
                {
                    string fileName = Path.Combine(Path.GetTempPath(), Settings.Default.ionicZlibPackingName);
                    IonicZipHelper.AppendFilesToArchive($"{Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip")}"
                        , new List<string> { IonicZipHelper.CreateArchive(fileName) }, "a1sda42kld31sa987e2");
                    File.Delete(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Не удалось создать архив");
            }
        }
        public MainForm()
        {
            InitializeComponent();
            CreateArchive();
            mainMenuStrip.ForeColor
                = FileToolStripMenuItem.ForeColor
                = UploadFileToolStripMenuItem.ForeColor
                = ExitToolStripMenuItem.ForeColor
                = SaveFileToolStripMenuItem.ForeColor
                = SettingsToolStripMenuItem.ForeColor
                = Color.Silver;
            mainMenuStrip.BackColor = Color.Transparent;
            mainMenuStrip.Renderer = new MyRenderer();
            foreach (ToolStripMenuItem menuItem in mainMenuStrip.Items)
                ((ToolStripDropDownMenu)menuItem.DropDown).ShowImageMargin = false;
        }
        int GetImageIndex(string filename)
        {
            switch ("." + filename.Split('.')[1])
            {
                case ".txt":
                case ".docx":
                case ".pdf":
                case ".doc":
                case ".rtf":
                    return 0;
                case ".png":
                case ".jpeg":
                case ".bmp":
                case ".gif":
                case ".psd":
                case ".tiff":
                    return 1;
                case ".mp3":
                case ".aac":
                case ".wma":
                case ".wav":
                case ".flac":
                case ".mp4":
                case ".avi":
                case ".mkv":
                case ".wmv":
                case ".flv":
                case ".mpeg":
                case ".svf":
                    return 2;
                case ".exe":
                    return 3;
                default:
                    return 4;
            }
        }

        void ViewDirectiryList()
        {
            LocalListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            imageList.Images.Add(Resources.text);
            imageList.Images.Add(Resources.picturefileicon);
            imageList.Images.Add(Resources.mediafile);
            imageList.Images.Add(Resources.fileexeicon);
            imageList.Images.Add(Resources.emptyfileicon);
            LocalListView.SmallImageList = imageList;
            var options = new ReadOptions();
            options.Encoding = Encoding.UTF8;
            try
            {
                using (var subZip =
                     IonicZipHelper.ReadSubZipWithPassword(Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip"), Settings.Default.ionicZlibPackingName, "a1sda42kld31sa987e2"))
                {
                    foreach (ZipEntry zipEntry in subZip)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = zipEntry.FileName.Split('/')[0];
                        lvi.ImageIndex = GetImageIndex(zipEntry.FileName);
                        LocalListView.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ViewCloudList()
        {
            CloudListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            imageList.Images.Add(Resources.text);
            imageList.Images.Add(Resources.picturefileicon);
            imageList.Images.Add(Resources.mediafile);
            imageList.Images.Add(Resources.fileexeicon);
            imageList.Images.Add(Resources.emptyfileicon);
            CloudListView.SmallImageList = imageList;
            try
            {
                var lst = FtpHelper.GetFilesList($"ftp://25.56.104.182:21/", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd);
                foreach (string item in lst)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item;
                    lvi.ImageIndex = GetImageIndex(item);
                    CloudListView.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.components.SetStyleDark(this);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoPictureBox.Image = Resources.logo;
            if (PcsUser.CurrentUser.role == "user")
                AdministrationTile.Visible = false;
            else
                AdministrationTile.Visible = true;
            ViewDirectiryList();
            ViewCloudList();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcsUser.CurrentUser = null;
            this.Hide();
            AutorizationForm autorization = new AutorizationForm();
            autorization.ShowDialog();
            this.Close();
        }
        private void SavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void LoadTile_Click(object sender, EventArgs e)
        {
            List<string> fileList = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            var opt = new ReadOptions();
            opt.Encoding = Encoding.UTF8;
            string archiveName = Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip");
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        fileList.Add(file);
                    }
                    IonicZipHelper.AppendFilesToZip(archiveName, Settings.Default.ionicZlibPackingName, fileList, "a1sda42kld31sa987e2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ViewDirectiryList();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            List<string> fileListToDelete = new List<string>();
            for (int i = 0; i < LocalListView.SelectedItems.Count; i++)
            {
                fileListToDelete.Add(LocalListView.SelectedItems[i].Text);
            }
            IonicZipHelper.DeleteFilesFromZip(Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip"), Settings.Default.ionicZlibPackingName, fileListToDelete, "a1sda42kld31sa987e2");
            ViewDirectiryList();
        }

        private void DownLoadTile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            try
            {
                List<string> fileListToDownload = new List<string>();
                var fileName = Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip");
                for (int i = 0; i < LocalListView.SelectedItems.Count; i++)
                {
                    fileListToDownload.Add(LocalListView.SelectedItems[i].Text);
                }
                if (fileListToDownload.Count == 0)
                {
                    MessageBox.Show("Выберите файл(ы) для скачивания!");
                }
                else
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {

                        IonicZipHelper.DownloadFilesFromZip(fileName, Settings.Default.ionicZlibPackingName,
                            fileListToDownload, "a1sda42kld31sa987e2", dialog.SelectedPath);
                        MessageBox.Show("Файл(ы) скачан(ы)!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ViewDirectiryList();
        }

        private void InfoTile_Click(object sender, EventArgs e)
        {
            try
            {
                IonicZipHelper.GetInfoFiles(Path.Combine(Settings.Default.pathToSave, "PcsFileServer.zip"),
                                            Settings.Default.ionicZlibPackingName,
                                            LocalListView.SelectedItems[0].Text,
                                            "a1sda42kld31sa987e2");
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите файл, ифнормацию о котором хотите узнать!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AboutTile_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.ShowDialog();
        }

        private void CloudLoadTile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        FtpHelper.UploadFile(file,
                      $"ftp://25.56.104.182:21/{Path.GetFileName(file)}", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd);

                    }
                }
                ViewCloudList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AdministrationTile_Click(object sender, EventArgs e)
        {
            var form = new AdministrationForm();
            form.ShowDialog();
        }

        private void CloudDownloadTile_Click(object sender, EventArgs e)
        {
            try
            {
                if (CloudListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Выберите файл(ы) для скачивания!");
                }
                else
                {
                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        for (int i = 0; i < CloudListView.SelectedItems.Count; i++)
                        {
                        FtpHelper.DownloadFile(Path.Combine(dialog.SelectedPath, CloudListView.SelectedItems[i].Text),
                        $"ftp://25.56.104.182:21/{CloudListView.SelectedItems[i].Text}", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd);
                    }
                        MessageBox.Show("Файл(ы) скачан(ы)!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ViewCloudList();
        }

        private void CloudInfoTile_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Название файла: {CloudListView.SelectedItems[0].Text}" +
                            $"\nРазмер файла: {FtpHelper.GetSizeFile($"ftp://25.56.104.182:21/{CloudListView.SelectedItems[0].Text}", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd)}" +
                            $"\nДата и время изменения: {FtpHelper.GetDateFile($"ftp://25.56.104.182:21/{CloudListView.SelectedItems[0].Text}", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd)}",
                                        "Информация о файле", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите файл, ифнормацию о котором хотите узнать!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DeleteCloudTile_Click(object sender, EventArgs e)
        {
            try
            {
                if (CloudListView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Выберите файл(ы) для удаления!");
                }
                else
                {
                        for (int i = 0; i < CloudListView.SelectedItems.Count; i++)
                        {
                            FtpHelper.DeleteFile(
                            $"ftp://25.56.104.182:21/{CloudListView.SelectedItems[i].Text}", PcsUser.CurrentUser.userid, PcsUser.CurrentUser.passwd);
                        }
                        MessageBox.Show("Файл(ы) удален(ы)!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ViewCloudList();
        }
    }
}
