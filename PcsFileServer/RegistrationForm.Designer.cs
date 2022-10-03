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
            this.components = new System.ComponentModel.Container();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPwdLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.MailLabel = new System.Windows.Forms.Label();
            this.CaptchaPictureBox = new System.Windows.Forms.PictureBox();
            this.UpdateCapthcaButton = new System.Windows.Forms.Button();
            this.CapthaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(13, 119);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 23);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBox_Validating);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(13, 57);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(220, 23);
            this.LoginTextBox.TabIndex = 6;
            this.LoginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTextBox_KeyPress);
            this.LoginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoginTextBox_Validating);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(15, 99);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(15, 37);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 16);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(13, 191);
            this.ConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(219, 23);
            this.ConfirmPasswordTextBox.TabIndex = 8;
            // 
            // ConfirmPwdLabel
            // 
            this.ConfirmPwdLabel.AutoSize = true;
            this.ConfirmPwdLabel.Location = new System.Drawing.Point(10, 171);
            this.ConfirmPwdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmPwdLabel.Name = "ConfirmPwdLabel";
            this.ConfirmPwdLabel.Size = new System.Drawing.Size(163, 16);
            this.ConfirmPwdLabel.TabIndex = 9;
            this.ConfirmPwdLabel.Text = "Подтверждение пароля";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(105, 431);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(327, 48);
            this.RegistrationButton.TabIndex = 10;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(276, 191);
            this.UserNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(219, 23);
            this.UserNameTextBox.TabIndex = 12;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(273, 171);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(129, 16);
            this.UserNameLabel.TabIndex = 11;
            this.UserNameLabel.Text = "Имя пользователя";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(273, 99);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(119, 16);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Номер телефона";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(276, 57);
            this.MailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(220, 23);
            this.MailTextBox.TabIndex = 16;
            this.MailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.MailTextBox_Validating);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(278, 37);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(39, 16);
            this.MailLabel.TabIndex = 15;
            this.MailLabel.Text = "Email";
            // 
            // CaptchaPictureBox
            // 
            this.CaptchaPictureBox.Location = new System.Drawing.Point(117, 246);
            this.CaptchaPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CaptchaPictureBox.Name = "CaptchaPictureBox";
            this.CaptchaPictureBox.Size = new System.Drawing.Size(200, 70);
            this.CaptchaPictureBox.TabIndex = 17;
            this.CaptchaPictureBox.TabStop = false;
            // 
            // UpdateCapthcaButton
            // 
            this.UpdateCapthcaButton.Location = new System.Drawing.Point(325, 246);
            this.UpdateCapthcaButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateCapthcaButton.Name = "UpdateCapthcaButton";
            this.UpdateCapthcaButton.Size = new System.Drawing.Size(86, 70);
            this.UpdateCapthcaButton.TabIndex = 19;
            this.UpdateCapthcaButton.Text = "Обновить";
            this.UpdateCapthcaButton.UseVisualStyleBackColor = true;
            this.UpdateCapthcaButton.Click += new System.EventHandler(this.UpdateCapthcaButton_Click);
            // 
            // CapthaTextBox
            // 
            this.CapthaTextBox.Location = new System.Drawing.Point(215, 363);
            this.CapthaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CapthaTextBox.Name = "CapthaTextBox";
            this.CapthaTextBox.Size = new System.Drawing.Size(115, 23);
            this.CapthaTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 343);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ввод каптча";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(275, 119);
            this.PhoneMaskedTextBox.Mask = "+7-(999) 000-00-00";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(220, 23);
            this.PhoneMaskedTextBox.TabIndex = 22;
            this.PhoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(519, 514);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.CapthaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateCapthcaButton);
            this.Controls.Add(this.CaptchaPictureBox);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.ConfirmPwdLabel);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPwdLabel;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.PictureBox CaptchaPictureBox;
        private System.Windows.Forms.Button UpdateCapthcaButton;
        private System.Windows.Forms.TextBox CapthaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
    }
}