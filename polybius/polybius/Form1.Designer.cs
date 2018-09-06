namespace polybius
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
            this.passText = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.selFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.fileTextOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(125, 66);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(184, 20);
            this.passText.TabIndex = 0;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(53, 119);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(152, 23);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // selFile
            // 
            this.selFile.Location = new System.Drawing.Point(53, 12);
            this.selFile.Name = "selFile";
            this.selFile.Size = new System.Drawing.Size(75, 23);
            this.selFile.TabIndex = 2;
            this.selFile.Text = "Select file";
            this.selFile.UseVisualStyleBackColor = true;
            this.selFile.Click += new System.EventHandler(this.selFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pass Phrase:";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(53, 175);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(152, 23);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // fileTextOutput
            // 
            this.fileTextOutput.Location = new System.Drawing.Point(53, 239);
            this.fileTextOutput.Multiline = true;
            this.fileTextOutput.Name = "fileTextOutput";
            this.fileTextOutput.ReadOnly = true;
            this.fileTextOutput.Size = new System.Drawing.Size(363, 158);
            this.fileTextOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 409);
            this.Controls.Add(this.fileTextOutput);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selFile);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.passText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button selFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox fileTextOutput;
    }
}

