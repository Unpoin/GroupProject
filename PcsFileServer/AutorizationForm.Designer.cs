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
            this.LoginMailLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.RegistrationButton = new MetroFramework.Controls.MetroButton();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.RecoverPasswordButton = new MetroFramework.Controls.MetroButton();
            this.RememberCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.OfflineCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ThemeToggle = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LoginMailLabel
            // 
            this.LoginMailLabel.AutoSize = true;
            this.LoginMailLabel.Location = new System.Drawing.Point(31, 103);
            this.LoginMailLabel.Name = "LoginMailLabel";
            this.LoginMailLabel.Size = new System.Drawing.Size(84, 19);
            this.LoginMailLabel.TabIndex = 9;
            this.LoginMailLabel.Text = "Логин/Email";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(34, 127);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(153, 23);
            this.LoginTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(34, 172);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 11;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(31, 220);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 23);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(31, 259);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(156, 23);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(34, 153);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(54, 19);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.Location = new System.Drawing.Point(34, 302);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(153, 38);
            this.RecoverPasswordButton.TabIndex = 16;
            this.RecoverPasswordButton.Text = "Забыли пароль? ";
            this.RecoverPasswordButton.Click += new System.EventHandler(this.RecoverPasswordButton_Click);
            // 
            // RememberCheckBox
            // 
            this.RememberCheckBox.AutoSize = true;
            this.RememberCheckBox.Location = new System.Drawing.Point(34, 362);
            this.RememberCheckBox.Name = "RememberCheckBox";
            this.RememberCheckBox.Size = new System.Drawing.Size(115, 15);
            this.RememberCheckBox.TabIndex = 17;
            this.RememberCheckBox.Text = "Запомнить меня";
            this.RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfflineCheckBox
            // 
            this.OfflineCheckBox.AutoSize = true;
            this.OfflineCheckBox.Location = new System.Drawing.Point(34, 393);
            this.OfflineCheckBox.Name = "OfflineCheckBox";
            this.OfflineCheckBox.Size = new System.Drawing.Size(136, 15);
            this.OfflineCheckBox.TabIndex = 18;
            this.OfflineCheckBox.Text = "Работать автономно";
            this.OfflineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThemeToggle
            // 
            this.ThemeToggle.AutoSize = true;
            this.ThemeToggle.Location = new System.Drawing.Point(115, 64);
            this.ThemeToggle.Name = "ThemeToggle";
            this.ThemeToggle.Size = new System.Drawing.Size(80, 20);
            this.ThemeToggle.TabIndex = 19;
            this.ThemeToggle.Text = "Off";
            this.ThemeToggle.UseVisualStyleBackColor = true;
            this.ThemeToggle.Click += new System.EventHandler(this.ThemeToggle_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Темная тема";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 419);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ThemeToggle);
            this.Controls.Add(this.OfflineCheckBox);
            this.Controls.Add(this.RememberCheckBox);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginMailLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
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
        private MetroFramework.Controls.MetroCheckBox RememberCheckBox;
        private MetroFramework.Controls.MetroCheckBox OfflineCheckBox;
        private MetroFramework.Controls.MetroToggle ThemeToggle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}