namespace FileIOSample
{
    partial class Form1
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
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.readDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(102, 80);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(349, 151);
            this.dataTextBox.TabIndex = 0;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(102, 285);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(157, 96);
            this.saveDataButton.TabIndex = 1;
            this.saveDataButton.Text = "Save Data To Text File";
            this.saveDataButton.UseVisualStyleBackColor = true;
            this.saveDataButton.Click += new System.EventHandler(this.saveDataButton_Click);
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(286, 285);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(165, 96);
            this.readDataButton.TabIndex = 2;
            this.readDataButton.Text = "Read Data From Text File";
            this.readDataButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.dataTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button readDataButton;
    }
}

