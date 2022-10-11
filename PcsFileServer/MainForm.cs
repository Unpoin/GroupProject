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
            menuStrip1.ForeColor
                = FileToolStripMenuItem.ForeColor
                = UploadFileToolStripMenuItem.ForeColor
                = ExitToolStripMenuItem.ForeColor
                = SaveFileToolStripMenuItem.ForeColor
                = SettingsToolStripMenuItem.ForeColor
                = InfoToolStripMenuItem.ForeColor
                = Color.Silver;
            menuStrip1.BackColor = Color.Transparent;
           
        }
        private static void DeleteTempDirectory()
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "TestArchives");
            if (Directory.Exists(directory))
                Directory.Delete(directory, true);
        }

        private static string CreateEmptyDirectory()
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "TestArchives");
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.components.SetStyleDark(this);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PcsUser.CurrentUser = null;
            AutorizationForm autorization = new AutorizationForm();
            this.Hide();
            autorization.ShowDialog();
            this.Close();
        }

        private void CreateArchiveButton_Click(object sender, EventArgs e)
        {
            var directory = CreateEmptyDirectory();
            var zipHelper = new IonicZipHelper();
            var resultFile = Path.Combine(Directory.GetCurrentDirectory(), "result.txt");
            if (File.Exists(resultFile))
                File.Delete(resultFile);

            var sourceDirectory = @"C:\Users\Roman\Documents\Case";
            var size = GetDirectorySize(sourceDirectory);
            File.AppendAllText(resultFile, string.Format("Directory size {0} bytes {1}", size, Environment.NewLine));

            var ionicZlibPacking = "IonicZlibPacking.zip";

            string fileName = Path.Combine(directory, ionicZlibPacking);
            var result = Profiler.MeasureAction(() => zipHelper.CompressionDirectory(fileName,sourceDirectory));
            File.AppendAllText(resultFile, string.Format("Zip directory with ZipFile {0} msec, Size: {1}{2}",
                result,
                new FileInfo(fileName).Length,
                Environment.NewLine));
            ///////////////////////////////////
            var tempFileOne = Path.Combine(directory, Guid.NewGuid().ToString());
            var tempFileTwo = Path.Combine(directory, Guid.NewGuid().ToString());
            File.AppendAllText(tempFileOne, "test1");
            File.AppendAllText(tempFileTwo, "test2");
            zipHelper.AppendFilesToZip(fileName,
                new List<string>(new[] { tempFileOne, tempFileTwo }));
        }
    }
}
