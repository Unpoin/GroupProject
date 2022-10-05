namespace PcsFileServer
{
    partial class RegistrationForm
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
            this.CaptchaPictureBox = new System.Windows.Forms.PictureBox();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginLabel = new MetroFramework.Controls.MetroLabel();
            this.MailLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PhoneLabel = new MetroFramework.Controls.MetroLabel();
            this.ConfirmPwdLabel = new MetroFramework.Controls.MetroLabel();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.LoginTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ConfirmPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.MailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateCapthcaButton = new MetroFramework.Controls.MetroButton();
            this.RegistrationButton = new MetroFramework.Controls.MetroButton();
            this.CapthaTextBox = new MetroFramework.Controls.MetroTextBox();
            this.w = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaPictureBox
            // 
            this.CaptchaPictureBox.Location = new System.Drawing.Point(17, 253);
            this.CaptchaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CaptchaPictureBox.Name = "CaptchaPictureBox";
            this.CaptchaPictureBox.Size = new System.Drawing.Size(200, 70);
            this.CaptchaPictureBox.TabIndex = 17;
            this.CaptchaPictureBox.TabStop = false;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.BackColor = System.Drawing.Color.Black;
            this.PhoneMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneMaskedTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(274, 155);
            this.PhoneMaskedTextBox.Mask = "+7-(999) 000-00-00";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(217, 16);
            this.PhoneMaskedTextBox.TabIndex = 22;
            this.PhoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(10, 65);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(53, 19);
            this.LoginLabel.TabIndex = 23;
            this.LoginLabel.Text = "Логин*";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(274, 65);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(47, 19);
            this.MailLabel.TabIndex = 24;
            this.MailLabel.Text = "Email*";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 133);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 19);
            this.PasswordLabel.TabIndex = 25;
            this.PasswordLabel.Text = "Пароль*";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(274, 133);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(112, 19);
            this.PhoneLabel.TabIndex = 26;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // ConfirmPwdLabel
            // 
            this.ConfirmPwdLabel.AutoSize = true;
            this.ConfirmPwdLabel.Location = new System.Drawing.Point(10, 191);
            this.ConfirmPwdLabel.Name = "ConfirmPwdLabel";
            this.ConfirmPwdLabel.Size = new System.Drawing.Size(161, 19);
            this.ConfirmPwdLabel.TabIndex = 27;
            this.ConfirmPwdLabel.Text = "Подтверждение пароля*";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(275, 191);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(122, 19);
            this.UserNameLabel.TabIndex = 28;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(13, 88);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(217, 23);
            this.LoginTextBox.TabIndex = 29;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(13, 155);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(217, 23);
            this.PasswordTextBox.TabIndex = 30;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(13, 213);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(217, 23);
            this.ConfirmPasswordTextBox.TabIndex = 31;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(274, 88);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(217, 23);
            this.MailTextBox.TabIndex = 32;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(274, 213);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(217, 23);
            this.UserNameTextBox.TabIndex = 33;
            // 
            // UpdateCapthcaButton
            // 
            this.UpdateCapthcaButton.Location = new System.Drawing.Point(225, 253);
            this.UpdateCapthcaButton.Name = "UpdateCapthcaButton";
            this.UpdateCapthcaButton.Size = new System.Drawing.Size(75, 70);
            this.UpdateCapthcaButton.TabIndex = 34;
            this.UpdateCapthcaButton.Text = "Обновить";
            this.UpdateCapthcaButton.Click += new System.EventHandler(this.UpdateCapthcaButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(225, 349);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(270, 48);
            this.RegistrationButton.TabIndex = 35;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click_1);
            // 
            // CapthaTextBox
            // 
            this.CapthaTextBox.Location = new System.Drawing.Point(13, 374);
            this.CapthaTextBox.Name = "CapthaTextBox";
            this.CapthaTextBox.Size = new System.Drawing.Size(83, 23);
            this.CapthaTextBox.TabIndex = 36;
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(13, 349);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(50, 19);
            this.w.TabIndex = 37;
            this.w.Text = "Каптча";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 425);
            this.Controls.Add(this.w);
            this.Controls.Add(this.CapthaTextBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.UpdateCapthcaButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ConfirmPwdLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.CaptchaPictureBox);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CaptchaPictureBox;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private MetroFramework.Controls.MetroButton UpdateCapthcaButton;
        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private MetroFramework.Controls.MetroTextBox MailTextBox;
        private MetroFramework.Controls.MetroTextBox ConfirmPasswordTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox LoginTextBox;
        private MetroFramework.Controls.MetroLabel UserNameLabel;
        private MetroFramework.Controls.MetroLabel ConfirmPwdLabel;
        private MetroFramework.Controls.MetroLabel PhoneLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroLabel MailLabel;
        private MetroFramework.Controls.MetroLabel LoginLabel;
        private MetroFramework.Controls.MetroButton RegistrationButton;
        private MetroFramework.Controls.MetroLabel w;
        private MetroFramework.Controls.MetroTextBox CapthaTextBox;
    }
}