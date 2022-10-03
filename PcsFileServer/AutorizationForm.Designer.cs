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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RememberCheckBox = new System.Windows.Forms.CheckBox();
            this.OfflineCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.RecoverPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(32, 22);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(84, 16);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин/Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 97);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(36, 53);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(152, 23);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(36, 128);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(152, 23);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // RememberCheckBox
            // 
            this.RememberCheckBox.AutoSize = true;
            this.RememberCheckBox.Location = new System.Drawing.Point(36, 340);
            this.RememberCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RememberCheckBox.Name = "RememberCheckBox";
            this.RememberCheckBox.Size = new System.Drawing.Size(133, 20);
            this.RememberCheckBox.TabIndex = 4;
            this.RememberCheckBox.Text = "Запомнить меня";
            this.RememberCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfflineCheckBox
            // 
            this.OfflineCheckBox.AutoSize = true;
            this.OfflineCheckBox.Location = new System.Drawing.Point(36, 380);
            this.OfflineCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.OfflineCheckBox.Name = "OfflineCheckBox";
            this.OfflineCheckBox.Size = new System.Drawing.Size(163, 20);
            this.OfflineCheckBox.TabIndex = 5;
            this.OfflineCheckBox.Text = "Работать автономно";
            this.OfflineCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(36, 171);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(153, 28);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Авторизоваться";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(35, 221);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(153, 28);
            this.RegistrationButton.TabIndex = 7;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RecoverPasswordButton
            // 
            this.RecoverPasswordButton.Location = new System.Drawing.Point(36, 270);
            this.RecoverPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.RecoverPasswordButton.Name = "RecoverPasswordButton";
            this.RecoverPasswordButton.Size = new System.Drawing.Size(153, 42);
            this.RecoverPasswordButton.TabIndex = 8;
            this.RecoverPasswordButton.Text = "Забыли пароль? ";
            this.RecoverPasswordButton.UseVisualStyleBackColor = true;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(232, 426);
            this.Controls.Add(this.RecoverPasswordButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.OfflineCheckBox);
            this.Controls.Add(this.RememberCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox RememberCheckBox;
        private System.Windows.Forms.CheckBox OfflineCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button RecoverPasswordButton;
    }
}