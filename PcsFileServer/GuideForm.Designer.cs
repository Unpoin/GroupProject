namespace PcsFileServer
{
    partial class GuideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideForm));
            this.GuideWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // GuideWebBrowser
            // 
            this.GuideWebBrowser.Location = new System.Drawing.Point(0, 5);
            this.GuideWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GuideWebBrowser.Name = "GuideWebBrowser";
            this.GuideWebBrowser.Size = new System.Drawing.Size(819, 478);
            this.GuideWebBrowser.TabIndex = 0;
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 486);
            this.Controls.Add(this.GuideWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(864, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(864, 486);
            this.Name = "GuideForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser GuideWebBrowser;
    }
}