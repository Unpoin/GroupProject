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
            this.RememberToggle = new MetroFramework.Controls.MetroToggle();
            this.RememberLabel = new MetroFramework.Controls.MetroLabel();
            this.OfflineLabel = new MetroFramework.Controls.MetroLabel();
            this.OfflineToggle = new MetroFramework.Controls.MetroToggle();
            this.SuspendLayout();
            // 
            // LoginMailLabel
            // 
            this.LoginMailLabel.AutoSize = true;
            this.LoginMailLabel.Location = new System.Drawing.Point(23, 74);
            this.LoginMailLabel.Name = "LoginMailLabel";
            this.LoginMailLabel.Size = new System.Drawing.Size(84, 19);
            this.LoginMailLabel.TabIndex = 9;
            this.LoginMailLabel.Text = "Логин/Email";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(26, 98);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(153, 23);
            this.LoginTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(26, 143);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 11;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 191);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(156, 23);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(23, 230);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(156, 23);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(26, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(54, 19);
            this.PasswordLabel.TabIndex = 15;
            this.PasswordLabel.Text = "Пароль";
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.Location = new System.Drawing.Point(26, 273);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(153, 38);
            this.RecoverPasswordButton.TabIndex = 16;
            this.RecoverPasswordButton.Text = "Забыли пароль? ";
            this.RecoverPasswordButton.Click += new System.EventHandler(this.RecoverPasswordButton_Click);
            // 
            // RememberToggle
            // 
            this.RememberToggle.AutoSize = true;
            this.RememberToggle.Location = new System.Drawing.Point(23, 336);
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
            this.RememberLabel.Location = new System.Drawing.Point(26, 314);
            this.RememberLabel.Name = "RememberLabel";
            this.RememberLabel.Size = new System.Drawing.Size(111, 19);
            this.RememberLabel.TabIndex = 20;
            this.RememberLabel.Text = "Запомнить меня";
            // 
            // OfflineLabel
            // 
            this.OfflineLabel.AutoSize = true;
            this.OfflineLabel.Location = new System.Drawing.Point(23, 362);
            this.OfflineLabel.Name = "OfflineLabel";
            this.OfflineLabel.Size = new System.Drawing.Size(135, 19);
            this.OfflineLabel.TabIndex = 21;
            this.OfflineLabel.Text = "Работать автономно";
            // 
            // OfflineToggle
            // 
            this.OfflineToggle.AutoSize = true;
            this.OfflineToggle.Location = new System.Drawing.Point(23, 384);
            this.OfflineToggle.Name = "OfflineToggle";
            this.OfflineToggle.Size = new System.Drawing.Size(80, 20);
            this.OfflineToggle.TabIndex = 22;
            this.OfflineToggle.Text = "Off";
            this.OfflineToggle.UseVisualStyleBackColor = true;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 419);
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
    }
}