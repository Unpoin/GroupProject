namespace PcsFileServer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalListView = new System.Windows.Forms.ListView();
            this.LoadTile = new MetroFramework.Controls.MetroTile();
            this.DownLoadTile = new MetroFramework.Controls.MetroTile();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.InfoTile = new MetroFramework.Controls.MetroTile();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(23, 60);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(860, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFileToolStripMenuItem,
            this.UploadFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.SaveFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveFileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // UploadFileToolStripMenuItem
            // 
            this.UploadFileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.UploadFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UploadFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem";
            this.UploadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UploadFileToolStripMenuItem.Text = "Выгрузить";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePathToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.SettingsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // SavePathToolStripMenuItem
            // 
            this.SavePathToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.SavePathToolStripMenuItem.Name = "SavePathToolStripMenuItem";
            this.SavePathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SavePathToolStripMenuItem.Text = "Изменить путь";
            this.SavePathToolStripMenuItem.Click += new System.EventHandler(this.SavePathToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InfoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InfoToolStripMenuItem.Text = "О программе";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // LocalListView
            // 
            this.LocalListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LocalListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.LocalListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocalListView.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.LocalListView.ForeColor = System.Drawing.Color.Silver;
            this.LocalListView.HideSelection = false;
            this.LocalListView.Location = new System.Drawing.Point(23, 129);
            this.LocalListView.Name = "LocalListView";
            this.LocalListView.Size = new System.Drawing.Size(411, 422);
            this.LocalListView.TabIndex = 4;
            this.LocalListView.UseCompatibleStateImageBehavior = false;
            this.LocalListView.View = System.Windows.Forms.View.List;
            // 
            // LoadTile
            // 
            this.LoadTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.LoadTile.ForeColor = System.Drawing.Color.Silver;
            this.LoadTile.Location = new System.Drawing.Point(23, 111);
            this.LoadTile.Name = "LoadTile";
            this.LoadTile.Size = new System.Drawing.Size(103, 19);
            this.LoadTile.TabIndex = 9;
            this.LoadTile.Text = "Добавить";
            this.LoadTile.Click += new System.EventHandler(this.LoadTile_Click);
            // 
            // DownLoadTile
            // 
            this.DownLoadTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.DownLoadTile.ForeColor = System.Drawing.Color.Silver;
            this.DownLoadTile.Location = new System.Drawing.Point(126, 111);
            this.DownLoadTile.Name = "DownLoadTile";
            this.DownLoadTile.Size = new System.Drawing.Size(103, 19);
            this.DownLoadTile.TabIndex = 10;
            this.DownLoadTile.Text = "Скачать";
            this.DownLoadTile.Click += new System.EventHandler(this.DownLoadTile_Click);
            // 
            // DeleteTile
            // 
            this.DeleteTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.DeleteTile.ForeColor = System.Drawing.Color.Silver;
            this.DeleteTile.Location = new System.Drawing.Point(229, 111);
            this.DeleteTile.Name = "DeleteTile";
            this.DeleteTile.Size = new System.Drawing.Size(103, 19);
            this.DeleteTile.TabIndex = 11;
            this.DeleteTile.Text = "Удалить";
            this.DeleteTile.Click += new System.EventHandler(this.DeleteTile_Click);
            // 
            // InfoTile
            // 
            this.InfoTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.InfoTile.ForeColor = System.Drawing.Color.Silver;
            this.InfoTile.Location = new System.Drawing.Point(331, 111);
            this.InfoTile.Name = "InfoTile";
            this.InfoTile.Size = new System.Drawing.Size(103, 19);
            this.InfoTile.TabIndex = 12;
            this.InfoTile.Text = "Инфо";
            this.InfoTile.Click += new System.EventHandler(this.InfoTile_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(207, 21);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(47, 33);
            this.LogoPictureBox.TabIndex = 13;
            this.LogoPictureBox.TabStop = false;
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroTile1.ForeColor = System.Drawing.Color.Silver;
            this.metroTile1.Location = new System.Drawing.Point(798, 111);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(103, 19);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "Инфо";
            // 
            // metroTile2
            // 
            this.metroTile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroTile2.ForeColor = System.Drawing.Color.Silver;
            this.metroTile2.Location = new System.Drawing.Point(696, 111);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(103, 19);
            this.metroTile2.TabIndex = 17;
            this.metroTile2.Text = "Удалить";
            // 
            // metroTile3
            // 
            this.metroTile3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroTile3.ForeColor = System.Drawing.Color.Silver;
            this.metroTile3.Location = new System.Drawing.Point(593, 111);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(103, 19);
            this.metroTile3.TabIndex = 16;
            this.metroTile3.Text = "Скачать";
            // 
            // metroTile4
            // 
            this.metroTile4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroTile4.ForeColor = System.Drawing.Color.Silver;
            this.metroTile4.Location = new System.Drawing.Point(490, 111);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(103, 19);
            this.metroTile4.TabIndex = 15;
            this.metroTile4.Text = "Загрузить";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.listView1.ForeColor = System.Drawing.Color.Silver;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(490, 129);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 422);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 560);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.InfoTile);
            this.Controls.Add(this.DeleteTile);
            this.Controls.Add(this.DownLoadTile);
            this.Controls.Add(this.LoadTile);
            this.Controls.Add(this.LocalListView);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(906, 560);
            this.MinimumSize = new System.Drawing.Size(906, 560);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 19);
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ListView LocalListView;
        private System.Windows.Forms.ToolStripMenuItem SavePathToolStripMenuItem;
        private MetroFramework.Controls.MetroTile LoadTile;
        private MetroFramework.Controls.MetroTile DownLoadTile;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile InfoTile;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
        private System.Windows.Forms.ListView listView1;
    }
}

