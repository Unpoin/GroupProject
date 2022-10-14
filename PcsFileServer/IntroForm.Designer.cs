namespace PcsFileServer
{
    partial class IntroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.IntroPictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IntroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.IntroPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IntroPictureBox
            // 
            this.IntroPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntroPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IntroPictureBox.Image")));
            this.IntroPictureBox.Location = new System.Drawing.Point(0, 0);
            this.IntroPictureBox.Name = "IntroPictureBox";
            this.IntroPictureBox.Size = new System.Drawing.Size(500, 350);
            this.IntroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IntroPictureBox.TabIndex = 0;
            this.IntroPictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntroProgressBar
            // 
            this.IntroProgressBar.Location = new System.Drawing.Point(0, 332);
            this.IntroProgressBar.Name = "IntroProgressBar";
            this.IntroProgressBar.Size = new System.Drawing.Size(500, 18);
            this.IntroProgressBar.Style = MetroFramework.MetroColorStyle.Purple;
            this.IntroProgressBar.TabIndex = 1;
            this.IntroProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.ControlBox = false;
            this.Controls.Add(this.IntroProgressBar);
            this.Controls.Add(this.IntroPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroForm";
            ((System.ComponentModel.ISupportInitialize)(this.IntroPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IntroPictureBox;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar IntroProgressBar;
    }
}