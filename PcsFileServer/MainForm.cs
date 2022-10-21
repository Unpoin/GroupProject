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
        //private static void DeleteTempDirectory()
        //{
        //    var directory = Path.Combine(Directory.GetCurrentDirectory(), "TestArchives");
        //    if (Directory.Exists(directory))
        //        Directory.Delete(directory, true);
        //}
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
            imageList.Images.Add(Resources.text);
            imageList.Images.Add(Resources.picturefileicon);
            imageList.Images.Add(Resources.mediafile);
            imageList.Images.Add(Resources.fileexeicon);
            imageList.Images.Add(Resources.emptyfileicon);
            LocalListView.SmallImageList = imageList;
            string archiveName = "C:\\Users\\Miho\\Documents\\Temp\\PcsFileServer.zip";
            //string fileName = Path.Combine(archiveName, Settings.Default.ionicZlibPackingName);
            var options = new ReadOptions();
            options.Encoding = Encoding.UTF8;
            try
            {
                using (var subZip =
                     IonicZipHelper.ReadSubZipWithPassword(archiveName, Settings.Default.ionicZlibPackingName, "a1sda42kld31sa987e2"))
                {

                    //using (ZipFile zip = ZipFile.Read(directory, options))
                    //{
                    foreach (ZipEntry zipEntry in subZip)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = zipEntry.FileName.Split('/')[0];
                        lvi.ImageIndex = GetImageIndex(zipEntry.FileName);
                        LocalListView.Items.Add(lvi);
                    }
                    //}
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
            //var ionicZlibPacking = "PcsFileServer.zip";
            //string fileName = Path.Combine(directory, ionicZlibPacking);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            var opt = new ReadOptions();
            opt.Encoding = Encoding.UTF8;
            string archiveName = "C:\\Users\\Miho\\Documents\\Temp\\PcsFileServer.zip";

            //var directory = Path.Combine(Directory.GetCurrentDirectory(), "FileTemp");
            //string fileName = Path.Combine(directory, Settings.Default.ionicZlibPackingName);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dialog.FileNames)
                {
                    fileList.Add(file);
                }
                IonicZipHelper.AppendFilesToZip(archiveName, Settings.Default.ionicZlibPackingName, fileList, "a1sda42kld31sa987e2");
            }
            ViewDirectiryList();
        }
            ////LocalListView.SelectedItems[1].Text;

            //foreach (var item in LocalListView.SelectedItems[0].Text)
            //{
            //    fileListToDelete.Add(Convert.ToString(item));
            //}
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            List<string> fileListToDelete = new List<string>();
            string archiveName = "C:\\Users\\Miho\\Documents\\Temp\\PcsFileServer.zip";
            for (int i = 0; i < LocalListView.SelectedItems.Count; i++)
            {
                fileListToDelete.Add(LocalListView.SelectedItems[i].Text);
            }
            IonicZipHelper.DeleteFilesFromZip(archiveName, Settings.Default.ionicZlibPackingName, fileListToDelete, "a1sda42kld31sa987e2");
            ViewDirectiryList();
        }
    }
}
