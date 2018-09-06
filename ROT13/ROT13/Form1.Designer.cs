namespace ROT13
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
            this.selFile = new System.Windows.Forms.Button();
            this.encBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.fileTextOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selFile
            // 
            this.selFile.Location = new System.Drawing.Point(32, 27);
            this.selFile.Name = "selFile";
            this.selFile.Size = new System.Drawing.Size(75, 23);
            this.selFile.TabIndex = 0;
            this.selFile.Text = "Open file...";
            this.selFile.UseVisualStyleBackColor = true;
            this.selFile.Click += new System.EventHandler(this.selFile_Click);
            // 
            // encBtn
            // 
            this.encBtn.Location = new System.Drawing.Point(32, 104);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(75, 23);
            this.encBtn.TabIndex = 1;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(164, 104);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(75, 23);
            this.decBtn.TabIndex = 2;
            this.decBtn.Text = "Decrypt";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // fileTextOutput
            // 
            this.fileTextOutput.Location = new System.Drawing.Point(32, 148);
            this.fileTextOutput.Multiline = true;
            this.fileTextOutput.Name = "fileTextOutput";
            this.fileTextOutput.ReadOnly = true;
            this.fileTextOutput.Size = new System.Drawing.Size(371, 160);
            this.fileTextOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 320);
            this.Controls.Add(this.fileTextOutput);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.encBtn);
            this.Controls.Add(this.selFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selFile;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.TextBox fileTextOutput;
    }
}

