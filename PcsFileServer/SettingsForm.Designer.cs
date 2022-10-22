namespace PcsFileServer
{
    partial class SettingsForm
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
            this.PathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ChangePathButton = new MetroFramework.Controls.MetroButton();
            this.SavePathButton = new MetroFramework.Controls.MetroButton();
            this.PathLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(10, 109);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(351, 23);
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.Text = "C:\\Users\\Miho\\Documents\\Temp";
            // 
            // ChangePathButton
            // 
            this.ChangePathButton.Location = new System.Drawing.Point(368, 109);
            this.ChangePathButton.Name = "ChangePathButton";
            this.ChangePathButton.Size = new System.Drawing.Size(42, 23);
            this.ChangePathButton.TabIndex = 1;
            this.ChangePathButton.Text = "...";
            this.ChangePathButton.Click += new System.EventHandler(this.ChangePathButton_Click);
            // 
            // SavePathButton
            // 
            this.SavePathButton.Location = new System.Drawing.Point(10, 154);
            this.SavePathButton.Name = "SavePathButton";
            this.SavePathButton.Size = new System.Drawing.Size(400, 26);
            this.SavePathButton.TabIndex = 2;
            this.SavePathButton.Text = "Сохранить";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(10, 87);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(221, 19);
            this.PathLabel.TabIndex = 3;
            this.PathLabel.Text = "Путь локального хранения данных";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.SavePathButton);
            this.Controls.Add(this.ChangePathButton);
            this.Controls.Add(this.PathTextBox);
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox PathTextBox;
        private MetroFramework.Controls.MetroButton ChangePathButton;
        private MetroFramework.Controls.MetroButton SavePathButton;
        private MetroFramework.Controls.MetroLabel PathLabel;
    }
}