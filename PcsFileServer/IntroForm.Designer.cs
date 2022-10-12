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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.IntroBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.IntroPictureBox = new System.Windows.Forms.PictureBox();
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
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.ControlBox = false;
            this.Controls.Add(this.IntroPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntroForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroForm";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IntroPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker IntroBackgroundWorker;
        private System.Windows.Forms.PictureBox IntroPictureBox;
    }
}