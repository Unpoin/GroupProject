namespace PcsFileServer
{
    partial class RecoverForm
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
            this.MailLabel = new System.Windows.Forms.Label();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.RecoverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(73, 38);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(126, 16);
            this.MailLabel.TabIndex = 0;
            this.MailLabel.Text = "Введите ваш Email";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(34, 80);
            this.MailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(214, 23);
            this.MailTextBox.TabIndex = 1;
            this.MailTextBox.Text = "dirofeev220@mail.ru";
            // 
            // RecoverButton
            // 
            this.RecoverButton.Location = new System.Drawing.Point(76, 126);
            this.RecoverButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.Size = new System.Drawing.Size(123, 28);
            this.RecoverButton.TabIndex = 2;
            this.RecoverButton.Text = "Восстановить";
            this.RecoverButton.UseVisualStyleBackColor = true;
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(279, 228);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecoverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Button RecoverButton;


    }
}