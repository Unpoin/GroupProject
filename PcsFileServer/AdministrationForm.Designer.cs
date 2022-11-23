namespace PcsFileServer
{
    partial class AdministrationForm
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
            this.AboutTile = new MetroFramework.Controls.MetroTile();
            this.GuideTile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // AboutTile
            // 
            this.AboutTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.AboutTile.ForeColor = System.Drawing.Color.Silver;
            this.AboutTile.Location = new System.Drawing.Point(0, 5);
            this.AboutTile.Name = "AboutTile";
            this.AboutTile.Size = new System.Drawing.Size(103, 19);
            this.AboutTile.TabIndex = 25;
            this.AboutTile.Text = "О программе";
            this.AboutTile.Click += new System.EventHandler(this.AboutTile_Click);
            // 
            // GuideTile
            // 
            this.GuideTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.GuideTile.ForeColor = System.Drawing.Color.Silver;
            this.GuideTile.Location = new System.Drawing.Point(103, 5);
            this.GuideTile.Name = "GuideTile";
            this.GuideTile.Size = new System.Drawing.Size(22, 19);
            this.GuideTile.TabIndex = 26;
            this.GuideTile.Text = "?";
            this.GuideTile.Click += new System.EventHandler(this.GuideTile_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 384);
            this.ControlBox = false;
            this.Controls.Add(this.GuideTile);
            this.Controls.Add(this.AboutTile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrationForm";
            this.Text = "Администрирование";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile AboutTile;
        private MetroFramework.Controls.MetroTile GuideTile;
    }
}