using Ionic.Zip;
using MetroFramework.Forms;
using System;
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
        string directoryPath = @"E:\FileTemp";
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

        private static string CreateEmptyDirectory()
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            else
            {
                var files = Directory.GetFiles(directory);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
            return directory;
        }

        static long GetDirectorySize(string path)
        {
            var a = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            return a.Select(name => new FileInfo(name)).Select(info => info.Length).Sum();
        }
        void ViewDirectiryList()
        {
            LocalListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(30, 30);
            imageList.Images.Add(new Bitmap(@"C:\Users\Roman\Downloads\file.png"));
            LocalListView.SmallImageList = imageList;
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            var ionicZlibPacking = "PcsFileServer.zip";
            string fileName = Path.Combine(directory, ionicZlibPacking);
            var options = new ReadOptions();
            options.Encoding = Encoding.UTF8;
            using (ZipFile zip = ZipFile.Read(fileName, options))
            {
                foreach (ZipEntry zipEntry in zip)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = zipEntry.FileName.Split('/')[0];
                    lvi.ImageIndex = 0;
                    LocalListView.Items.Add(lvi);
                }
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
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            var zipHelper = new IonicZipHelper();
            var ionicZlibPacking = "PcsFileServer.zip";
            string fileName = Path.Combine(directory, ionicZlibPacking);
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                zipHelper.AppendFilesToZip(fileName,
                new List<string>(new[] { dialog.FileName }));
            }
            ViewDirectiryList();
        }
    }
}
