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
            this.LocalListView = new System.Windows.Forms.ListView();
            this.LoadTile = new MetroFramework.Controls.MetroTile();
            this.DownLoadTile = new MetroFramework.Controls.MetroTile();
            this.DeleteTile = new MetroFramework.Controls.MetroTile();
            this.InfoTile = new MetroFramework.Controls.MetroTile();
            this.CloudInfoTile = new MetroFramework.Controls.MetroTile();
            this.DeleteCloudTile = new MetroFramework.Controls.MetroTile();
            this.CloudDownloadTile = new MetroFramework.Controls.MetroTile();
            this.CloudLoadTile = new MetroFramework.Controls.MetroTile();
            this.CloudListView = new System.Windows.Forms.ListView();
            this.GuideTile = new MetroFramework.Controls.MetroTile();
            this.AdministrationTile = new MetroFramework.Controls.MetroTile();
            this.AboutTile = new MetroFramework.Controls.MetroTile();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LclTile = new MetroFramework.Controls.MetroTile();
            this.CldTile = new MetroFramework.Controls.MetroTile();
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
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // UploadFileToolStripMenuItem
            // 
            this.UploadFileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.UploadFileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UploadFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem";
            this.UploadFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.UploadFileToolStripMenuItem.Text = "Выгрузить";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ExitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePathToolStripMenuItem});
            this.SettingsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // SavePathToolStripMenuItem
            // 
            this.SavePathToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.SavePathToolStripMenuItem.Name = "SavePathToolStripMenuItem";
            this.SavePathToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SavePathToolStripMenuItem.Text = "Изменить путь";
            this.SavePathToolStripMenuItem.Click += new System.EventHandler(this.SavePathToolStripMenuItem_Click);
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
            this.LoadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DownLoadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DeleteTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.InfoTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InfoTile.Click += new System.EventHandler(this.InfoTile_Click);
            // 
            // CloudInfoTile
            // 
            this.CloudInfoTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudInfoTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.CloudInfoTile.ForeColor = System.Drawing.Color.Silver;
            this.CloudInfoTile.Location = new System.Drawing.Point(798, 111);
            this.CloudInfoTile.Name = "CloudInfoTile";
            this.CloudInfoTile.Size = new System.Drawing.Size(103, 19);
            this.CloudInfoTile.TabIndex = 18;
            this.CloudInfoTile.Text = "Инфо";
            this.CloudInfoTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloudInfoTile.Click += new System.EventHandler(this.CloudInfoTile_Click);
            // 
            // DeleteCloudTile
            // 
            this.DeleteCloudTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteCloudTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.DeleteCloudTile.ForeColor = System.Drawing.Color.Silver;
            this.DeleteCloudTile.Location = new System.Drawing.Point(696, 111);
            this.DeleteCloudTile.Name = "DeleteCloudTile";
            this.DeleteCloudTile.Size = new System.Drawing.Size(103, 19);
            this.DeleteCloudTile.TabIndex = 17;
            this.DeleteCloudTile.Text = "Удалить";
            this.DeleteCloudTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteCloudTile.Click += new System.EventHandler(this.DeleteCloudTile_Click);
            // 
            // CloudDownloadTile
            // 
            this.CloudDownloadTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudDownloadTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.CloudDownloadTile.ForeColor = System.Drawing.Color.Silver;
            this.CloudDownloadTile.Location = new System.Drawing.Point(593, 111);
            this.CloudDownloadTile.Name = "CloudDownloadTile";
            this.CloudDownloadTile.Size = new System.Drawing.Size(103, 19);
            this.CloudDownloadTile.TabIndex = 16;
            this.CloudDownloadTile.Text = "Скачать";
            this.CloudDownloadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloudDownloadTile.Click += new System.EventHandler(this.CloudDownloadTile_Click);
            // 
            // CloudLoadTile
            // 
            this.CloudLoadTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudLoadTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.CloudLoadTile.ForeColor = System.Drawing.Color.Silver;
            this.CloudLoadTile.Location = new System.Drawing.Point(490, 111);
            this.CloudLoadTile.Name = "CloudLoadTile";
            this.CloudLoadTile.Size = new System.Drawing.Size(103, 19);
            this.CloudLoadTile.TabIndex = 15;
            this.CloudLoadTile.Text = "Загрузить";
            this.CloudLoadTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloudLoadTile.Click += new System.EventHandler(this.CloudLoadTile_Click);
            // 
            // CloudListView
            // 
            this.CloudListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloudListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.CloudListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CloudListView.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.CloudListView.ForeColor = System.Drawing.Color.Silver;
            this.CloudListView.HideSelection = false;
            this.CloudListView.Location = new System.Drawing.Point(490, 129);
            this.CloudListView.Name = "CloudListView";
            this.CloudListView.Size = new System.Drawing.Size(411, 422);
            this.CloudListView.TabIndex = 14;
            this.CloudListView.UseCompatibleStateImageBehavior = false;
            this.CloudListView.View = System.Windows.Forms.View.List;
            // 
            // GuideTile
            // 
            this.GuideTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.GuideTile.ForeColor = System.Drawing.Color.Silver;
            this.GuideTile.Location = new System.Drawing.Point(103, 5);
            this.GuideTile.Name = "GuideTile";
            this.GuideTile.Size = new System.Drawing.Size(22, 19);
            this.GuideTile.TabIndex = 24;
            this.GuideTile.Text = "?";
            // 
            // AdministrationTile
            // 
            this.AdministrationTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.AdministrationTile.ForeColor = System.Drawing.Color.Silver;
            this.AdministrationTile.Location = new System.Drawing.Point(593, 5);
            this.AdministrationTile.Name = "AdministrationTile";
            this.AdministrationTile.Size = new System.Drawing.Size(144, 19);
            this.AdministrationTile.TabIndex = 25;
            this.AdministrationTile.Text = "Администрирование";
            this.AdministrationTile.Click += new System.EventHandler(this.AdministrationTile_Click);
            // 
            // AboutTile
            // 
            this.AboutTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.AboutTile.ForeColor = System.Drawing.Color.Silver;
            this.AboutTile.Location = new System.Drawing.Point(0, 5);
            this.AboutTile.Name = "AboutTile";
            this.AboutTile.Size = new System.Drawing.Size(103, 19);
            this.AboutTile.TabIndex = 26;
            this.AboutTile.Text = "О программе";
            this.AboutTile.Click += new System.EventHandler(this.AboutTile_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(182, 10);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(47, 47);
            this.LogoPictureBox.TabIndex = 13;
            this.LogoPictureBox.TabStop = false;
            // 
            // LclTile
            // 
            this.LclTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.LclTile.Enabled = false;
            this.LclTile.ForeColor = System.Drawing.Color.Silver;
            this.LclTile.Location = new System.Drawing.Point(23, 88);
            this.LclTile.Name = "LclTile";
            this.LclTile.Size = new System.Drawing.Size(411, 22);
            this.LclTile.TabIndex = 27;
            this.LclTile.Text = "Локальное хранилище";
            this.LclTile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CldTile
            // 
            this.CldTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.CldTile.Enabled = false;
            this.CldTile.ForeColor = System.Drawing.Color.Silver;
            this.CldTile.Location = new System.Drawing.Point(490, 88);
            this.CldTile.Name = "CldTile";
            this.CldTile.Size = new System.Drawing.Size(411, 22);
            this.CldTile.TabIndex = 28;
            this.CldTile.Text = "Облачное хранилище";
            this.CldTile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 560);
            this.Controls.Add(this.CldTile);
            this.Controls.Add(this.LclTile);
            this.Controls.Add(this.AboutTile);
            this.Controls.Add(this.AdministrationTile);
            this.Controls.Add(this.GuideTile);
            this.Controls.Add(this.CloudInfoTile);
            this.Controls.Add(this.DeleteCloudTile);
            this.Controls.Add(this.CloudDownloadTile);
            this.Controls.Add(this.CloudLoadTile);
            this.Controls.Add(this.CloudListView);
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
        private System.Windows.Forms.ListView LocalListView;
        private System.Windows.Forms.ToolStripMenuItem SavePathToolStripMenuItem;
        private MetroFramework.Controls.MetroTile LoadTile;
        private MetroFramework.Controls.MetroTile DownLoadTile;
        private MetroFramework.Controls.MetroTile DeleteTile;
        private MetroFramework.Controls.MetroTile InfoTile;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private MetroFramework.Controls.MetroTile CloudInfoTile;
        private MetroFramework.Controls.MetroTile DeleteCloudTile;
        private MetroFramework.Controls.MetroTile CloudDownloadTile;
        private MetroFramework.Controls.MetroTile CloudLoadTile;
        private System.Windows.Forms.ListView CloudListView;
        private MetroFramework.Controls.MetroTile GuideTile;
        private MetroFramework.Controls.MetroTile AdministrationTile;
        private MetroFramework.Controls.MetroTile AboutTile;
        private MetroFramework.Controls.MetroTile LclTile;
        private MetroFramework.Controls.MetroTile CldTile;
    }
}

