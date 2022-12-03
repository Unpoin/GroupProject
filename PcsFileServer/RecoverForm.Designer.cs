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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverForm));
            this.MailLabel = new MetroFramework.Controls.MetroLabel();
            this.MailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.RecoverButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Location = new System.Drawing.Point(47, 79);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(123, 19);
            this.MailLabel.TabIndex = 3;
            this.MailLabel.Text = "Введите ваш Email";
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(27, 112);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(170, 23);
            this.MailTextBox.TabIndex = 4;
            // 
            // RecoverButton
            // 
            this.RecoverButton.Location = new System.Drawing.Point(57, 167);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.Size = new System.Drawing.Size(101, 23);
            this.RecoverButton.TabIndex = 5;
            this.RecoverButton.Text = "Восстановить";
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // RecoverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 228);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.MailLabel);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 228);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 228);
            this.Name = "RecoverForm";
            this.Text = "Восстановление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel MailLabel;
        private MetroFramework.Controls.MetroTextBox MailTextBox;
        private MetroFramework.Controls.MetroButton RecoverButton;
    }
}