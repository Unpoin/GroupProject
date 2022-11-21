namespace PcsFileServer
{
    partial class AutorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorizationForm));
            this.LoginMailLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.RegistrationButton = new MetroFramework.Controls.MetroButton();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.RecoverPasswordButton = new MetroFramework.Controls.MetroButton();
            this.RememberToggle = new MetroFramework.Controls.MetroToggle();
            this.RememberLabel = new MetroFramework.Controls.MetroLabel();
            this.OfflineLabel = new MetroFramework.Controls.MetroLabel();
            this.OfflineToggle = new MetroFramework.Controls.MetroToggle();
            this.DownLoadTile = new MetroFramework.Controls.MetroTile();
            this.AboutTile = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // LoginMailLabel
            // 
            this.LoginMailLabel.AutoSize = true;
            this.LoginMailLabel.Location = new System.Drawing.Point(30, 74);
            this.LoginMailLabel.Name = "LoginMailLabel";
            this.LoginMailLabel.Size = new System.Drawing.Size(84, 19);
            this.LoginMailLabel.TabIndex = 9;
            this.LoginMailLabel.Text = "Логин/Email";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(33, 98);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(153, 23);
            this.LoginTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(33, 143);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 11;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(30, 191);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 23);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(30, 230);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(156, 23);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(33, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(54, 19);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.Location = new System.Drawing.Point(33, 273);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(153, 38);
            this.RecoverPasswordButton.TabIndex = 16;
            this.RecoverPasswordButton.Text = "Забыли пароль? ";
            this.RecoverPasswordButton.Click += new System.EventHandler(this.RecoverPasswordButton_Click);
            // 
            // RememberToggle
            // 
            this.RememberToggle.AutoSize = true;
            this.RememberToggle.Location = new System.Drawing.Point(30, 336);
            this.RememberToggle.Name = "RememberToggle";
            this.RememberToggle.Size = new System.Drawing.Size(80, 20);
            this.RememberToggle.TabIndex = 19;
            this.RememberToggle.Text = "Off";
            this.RememberToggle.UseVisualStyleBackColor = true;
            this.RememberToggle.CheckedChanged += new System.EventHandler(this.RememberToggle_CheckedChanged);
            // 
            // RememberLabel
            // 
            this.RememberLabel.AutoSize = true;
            this.RememberLabel.Location = new System.Drawing.Point(33, 314);
            this.RememberLabel.Name = "RememberLabel";
            this.RememberLabel.Size = new System.Drawing.Size(111, 19);
            this.RememberLabel.TabIndex = 20;
            this.RememberLabel.Text = "Запомнить меня";
            // 
            // OfflineLabel
            // 
            this.OfflineLabel.AutoSize = true;
            this.OfflineLabel.Location = new System.Drawing.Point(30, 362);
            this.OfflineLabel.Name = "OfflineLabel";
            this.OfflineLabel.Size = new System.Drawing.Size(135, 19);
            this.OfflineLabel.TabIndex = 21;
            this.OfflineLabel.Text = "Работать автономно";
            // 
            // OfflineToggle
            // 
            this.OfflineToggle.AutoSize = true;
            this.OfflineToggle.Location = new System.Drawing.Point(30, 384);
            this.OfflineToggle.Name = "OfflineToggle";
            this.OfflineToggle.Size = new System.Drawing.Size(80, 20);
            this.OfflineToggle.TabIndex = 22;
            this.OfflineToggle.Text = "Off";
            this.OfflineToggle.UseVisualStyleBackColor = true;
            // 
            // DownLoadTile
            // 
            this.DownLoadTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.DownLoadTile.ForeColor = System.Drawing.Color.Silver;
            this.DownLoadTile.Location = new System.Drawing.Point(145, 2);
            this.DownLoadTile.Name = "DownLoadTile";
            this.DownLoadTile.Size = new System.Drawing.Size(22, 19);
            this.DownLoadTile.TabIndex = 23;
            this.DownLoadTile.Text = "?";
            // 
            // AboutTile
            // 
            this.AboutTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.AboutTile.ForeColor = System.Drawing.Color.Silver;
            this.AboutTile.Location = new System.Drawing.Point(0, 2);
            this.AboutTile.Name = "AboutTile";
            this.AboutTile.Size = new System.Drawing.Size(103, 19);
            this.AboutTile.TabIndex = 24;
            this.AboutTile.Text = "О программе";
            this.AboutTile.Click += new System.EventHandler(this.AboutTile_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroTile2.Enabled = false;
            this.metroTile2.ForeColor = System.Drawing.Color.Silver;
            this.metroTile2.Location = new System.Drawing.Point(103, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(42, 19);
            this.metroTile2.TabIndex = 25;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 419);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.AboutTile);
            this.Controls.Add(this.DownLoadTile);
            this.Controls.Add(this.OfflineToggle);
            this.Controls.Add(this.OfflineLabel);
            this.Controls.Add(this.RememberLabel);
            this.Controls.Add(this.RememberToggle);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginMailLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 400);
            this.Name = "AutorizationForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LoginMailLabel;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroButton RegistrationButton;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroButton RecoverPasswordButton;
        private MetroFramework.Controls.MetroToggle RememberToggle;
        private MetroFramework.Controls.MetroLabel RememberLabel;
        private MetroFramework.Controls.MetroLabel OfflineLabel;
        private MetroFramework.Controls.MetroToggle OfflineToggle;
        private MetroFramework.Controls.MetroTile DownLoadTile;
        private MetroFramework.Controls.MetroTile AboutTile;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}