namespace PcsFileServer
{
    partial class CodeReviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeReviewForm));
            this.CodeLabel = new MetroFramework.Controls.MetroLabel();
            this.CodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.ConfirmTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RecoverButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(66, 61);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(83, 19);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Введите код";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(32, 83);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(153, 23);
            this.CodeTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(32, 161);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(153, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(57, 139);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 19);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Введите пароль";
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.Location = new System.Drawing.Point(32, 225);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(153, 23);
            this.ConfirmTextBox.TabIndex = 5;
            this.ConfirmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmTextBox_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 203);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Подтвердите пароль";
            // 
            // RecoverButton
            // 
            this.RecoverButton.Location = new System.Drawing.Point(57, 270);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.Size = new System.Drawing.Size(101, 23);
            this.RecoverButton.TabIndex = 6;
            this.RecoverButton.Text = "Восстановить";
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // CodeReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 331);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.CodeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(226, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(226, 331);
            this.Name = "CodeReviewForm";
            this.Text = "Восстановление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel CodeLabel;
        private MetroFramework.Controls.MetroTextBox CodeTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MetroFramework.Controls.MetroTextBox ConfirmTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton RecoverButton;
    }
}