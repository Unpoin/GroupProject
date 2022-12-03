namespace PcsFileServer
{
    partial class InformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.OkTile = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.VersionLabel = new MetroFramework.Controls.MetroLabel();
            this.AboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.YearLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(72, 63);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // OkTile
            // 
            this.OkTile.Location = new System.Drawing.Point(0, 378);
            this.OkTile.Name = "OkTile";
            this.OkTile.Size = new System.Drawing.Size(200, 23);
            this.OkTile.TabIndex = 1;
            this.OkTile.Text = "OK";
            this.OkTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OkTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.OkTile.Click += new System.EventHandler(this.OkTile_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PcsFileServer";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(62, 159);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(72, 19);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "Версия 1.0";
            // 
            // AboutRichTextBox
            // 
            this.AboutRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.AboutRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutRichTextBox.ForeColor = System.Drawing.Color.Silver;
            this.AboutRichTextBox.Location = new System.Drawing.Point(54, 206);
            this.AboutRichTextBox.Name = "AboutRichTextBox";
            this.AboutRichTextBox.ReadOnly = true;
            this.AboutRichTextBox.Size = new System.Drawing.Size(95, 90);
            this.AboutRichTextBox.TabIndex = 4;
            this.AboutRichTextBox.Text = "Разработчики:\nВасильев Р. О.\nДорофеев К. А.\nАндронов Н. А.\n";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(77, 325);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(37, 19);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "2022";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 400);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.AboutRichTextBox);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.OkTile);
            this.Controls.Add(this.LogoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationForm";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private MetroFramework.Controls.MetroTile OkTile;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel VersionLabel;
        private System.Windows.Forms.RichTextBox AboutRichTextBox;
        private MetroFramework.Controls.MetroLabel YearLabel;
    }
}