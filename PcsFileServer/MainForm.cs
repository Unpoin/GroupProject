using Ionic.Zip;
using MetroFramework.Forms;
using PcsFileServer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PcsFileServer
{
    public partial class MainForm : MetroForm
    {
        public class TestColorTable : ProfessionalColorTable
        {
            Color mainColor = Color.Black;
            public override Color MenuItemSelected
            {
                get { return mainColor; }
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
                get { return mainColor; }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return mainColor; }
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
        public MainForm()
        {
            InitializeComponent();
            mainMenuStrip.ForeColor
                = FileToolStripMenuItem.ForeColor
                = UploadFileToolStripMenuItem.ForeColor
                = ExitToolStripMenuItem.ForeColor
                = SaveFileToolStripMenuItem.ForeColor
                = SettingsToolStripMenuItem.ForeColor
                = InfoToolStripMenuItem.ForeColor
                = Color.Silver;
            mainMenuStrip.BackColor = Color.Transparent;
           
        }
        private static void DeleteTempDirectory()
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "TestArchives");
            if (Directory.Exists(directory))
                Directory.Delete(directory, true);
        }
        //Path.GetExtension(file)
        int GetImageIndex(string filename)
        {
            switch(Path.GetExtension(filename))
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
            imageList.Images.Add(Properties.Resources.text);
            imageList.Images.Add(Properties.Resources.picturefileicon);
            imageList.Images.Add(Properties.Resources.mediafile);
            imageList.Images.Add(Properties.Resources.fileexeicon);
            imageList.Images.Add(Properties.Resources.emptyfileicon);
            LocalListView.SmallImageList = imageList;
            string directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            string fileName = Path.Combine(directory, Settings.Default.ionicZlibPackingName);
            var options = new ReadOptions();
            options.Encoding = Encoding.UTF8;
            try
            {
                using (ZipFile zip = ZipFile.Read(fileName, options))
                {
                    foreach (ZipEntry zipEntry in zip)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = zipEntry.FileName.Split('/')[0];
                        lvi.ImageIndex = GetImageIndex(zipEntry.FileName);
                        LocalListView.Items.Add(lvi);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.components.SetStyleDark(this);
            mainMenuStrip.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
            //на форме авторизации добавлять архив для пользователя если архива для него еще не существует
            //var directory = CreateEmptyDirectory();
            //var zipHelper = new IonicZipHelper();
            //var sourceDirecory = directoryPath;
            //var size = GetDirectorySize(sourceDirecory);
            //var ionicZlibPacking = "PcsFileServer.zip";
            //string fileName = Path.Combine(directory, ionicZlibPacking);
            //var result = Profiler.MeasureAction(() => zipHelper.CompressionDirectory(fileName, sourceDirecory));
            ViewDirectiryList();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcsUser.CurrentUser = null;
            this.Hide();
            AutorizationForm autorization = new AutorizationForm();
            autorization.ShowDialog();
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            List<string> fileList = new List<string>();
            //var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            var zipHelper = new IonicZipHelper();
            //var ionicZlibPacking = "PcsFileServer.zip";
            //string fileName = Path.Combine(directory, ionicZlibPacking);
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            var opt = new ReadOptions();
            opt.Encoding = Encoding.UTF8;
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            string fileName = Path.Combine(directory, Settings.Default.ionicZlibPackingName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dialog.FileNames)
                {
                    fileList.Add(file);
                }
                zipHelper.AppendFilesToZip(fileName, fileList);
            }
            ViewDirectiryList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
