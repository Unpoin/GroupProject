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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.AboutTile = new MetroFramework.Controls.MetroTile();
            this.GuideTile = new MetroFramework.Controls.MetroTile();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SearchLabel = new MetroFramework.Controls.MetroLabel();
            this.RedactButton = new MetroFramework.Controls.MetroButton();
            this.DeleteButton = new MetroFramework.Controls.MetroButton();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.RefreshPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.EmailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PhoneTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginLabel = new MetroFramework.Controls.MetroLabel();
            this.MailLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PhoneLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SaveUserButton = new MetroFramework.Controls.MetroButton();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).BeginInit();
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
            // UsersDataGrid
            // 
            this.UsersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.UsersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.passwd,
            this.name,
            this.email,
            this.phone,
            this.role});
            this.UsersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.UsersDataGrid.EnableHeadersVisualStyles = false;
            this.UsersDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UsersDataGrid.Location = new System.Drawing.Point(276, 120);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.RowHeadersVisible = false;
            this.UsersDataGrid.RowHeadersWidth = 90;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(601, 326);
            this.UsersDataGrid.TabIndex = 27;
            this.UsersDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.UsersDataGrid_CellFormatting);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(276, 91);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(164, 23);
            this.SearchTextBox.TabIndex = 28;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(446, 91);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 29;
            this.SearchButton.Text = "Найти";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(275, 69);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(47, 19);
            this.SearchLabel.TabIndex = 30;
            this.SearchLabel.Text = "Логин";
            // 
            // RedactButton
            // 
            this.RedactButton.Location = new System.Drawing.Point(276, 452);
            this.RedactButton.Name = "RedactButton";
            this.RedactButton.Size = new System.Drawing.Size(97, 23);
            this.RedactButton.TabIndex = 31;
            this.RedactButton.Text = "Редактировать";
            this.RedactButton.Click += new System.EventHandler(this.RedactButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(398, 452);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteButton.TabIndex = 32;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(43, 393);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(162, 23);
            this.AddButton.TabIndex = 33;
            this.AddButton.Text = "Добавить";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefreshPictureBox
            // 
            this.RefreshPictureBox.Location = new System.Drawing.Point(527, 91);
            this.RefreshPictureBox.Name = "RefreshPictureBox";
            this.RefreshPictureBox.Size = new System.Drawing.Size(23, 23);
            this.RefreshPictureBox.TabIndex = 34;
            this.RefreshPictureBox.TabStop = false;
            this.RefreshPictureBox.Click += new System.EventHandler(this.RefreshPictureBox_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(41, 120);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(164, 23);
            this.LoginTextBox.TabIndex = 35;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(41, 168);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(164, 23);
            this.PasswordTextBox.TabIndex = 36;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(41, 217);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(164, 23);
            this.EmailTextBox.TabIndex = 37;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(41, 264);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(164, 23);
            this.PhoneTextBox.TabIndex = 38;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(41, 312);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(164, 23);
            this.NameTextBox.TabIndex = 39;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(41, 98);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(53, 19);
            this.LoginLabel.TabIndex = 41;
            this.LoginLabel.Text = "Логин*";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(41, 195);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(47, 19);
            this.MailLabel.TabIndex = 42;
            this.MailLabel.Text = "Email*";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(43, 146);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 19);
            this.PasswordLabel.TabIndex = 43;
            this.PasswordLabel.Text = "Пароль*";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(41, 243);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(112, 19);
            this.PhoneLabel.TabIndex = 44;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(43, 290);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(122, 19);
            this.UserNameLabel.TabIndex = 45;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Location = new System.Drawing.Point(41, 352);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(164, 23);
            this.SaveUserButton.TabIndex = 46;
            this.SaveUserButton.Text = "Сохранить";
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "Логин";
            this.userid.Name = "userid";
            // 
            // passwd
            // 
            this.passwd.DataPropertyName = "passwd";
            this.passwd.HeaderText = "Пароль";
            this.passwd.Name = "passwd";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя пользователя";
            this.name.Name = "name";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Почта";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Роль";
            this.role.Name = "role";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.SaveUserButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RefreshPictureBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.RedactButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.GuideTile);
            this.Controls.Add(this.AboutTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "AdministrationForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.AdministrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile AboutTile;
        private MetroFramework.Controls.MetroTile GuideTile;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private MetroFramework.Controls.MetroButton RedactButton;
        private MetroFramework.Controls.MetroButton DeleteButton;
        private MetroFramework.Controls.MetroButton AddButton;
        private System.Windows.Forms.PictureBox RefreshPictureBox;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox EmailTextBox;
        private MetroFramework.Controls.MetroTextBox PhoneTextBox;
        private MetroFramework.Controls.MetroTextBox NameTextBox;
        private MetroFramework.Controls.MetroLabel LoginLabel;
        private MetroFramework.Controls.MetroLabel MailLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroLabel PhoneLabel;
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroButton SaveUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
    }
}