namespace straddleCheckboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.sparePositions = new System.Windows.Forms.TextBox();
            this.fileTextOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selFile
            // 
            this.selFile.Location = new System.Drawing.Point(40, 32);
            this.selFile.Name = "selFile";
            this.selFile.Size = new System.Drawing.Size(75, 23);
            this.selFile.TabIndex = 0;
            this.selFile.Text = "Open file...";
            this.selFile.UseVisualStyleBackColor = true;
            this.selFile.Click += new System.EventHandler(this.selFile_Click);
            // 
            // encBtn
            // 
            this.encBtn.Location = new System.Drawing.Point(40, 155);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(75, 23);
            this.encBtn.TabIndex = 1;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(160, 155);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(75, 23);
            this.decBtn.TabIndex = 2;
            this.decBtn.Text = "Decrypt";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spare positions:";
            // 
            // keyText
            // 
            this.keyText.Location = new System.Drawing.Point(125, 78);
            this.keyText.Name = "keyText";
            this.keyText.Size = new System.Drawing.Size(110, 20);
            this.keyText.TabIndex = 5;
            // 
            // sparePositions
            // 
            this.sparePositions.Location = new System.Drawing.Point(125, 110);
            this.sparePositions.Name = "sparePositions";
            this.sparePositions.Size = new System.Drawing.Size(110, 20);
            this.sparePositions.TabIndex = 6;
            // 
            // fileTextOutput
            // 
            this.fileTextOutput.Location = new System.Drawing.Point(40, 194);
            this.fileTextOutput.Multiline = true;
            this.fileTextOutput.Name = "fileTextOutput";
            this.fileTextOutput.ReadOnly = true;
            this.fileTextOutput.Size = new System.Drawing.Size(408, 229);
            this.fileTextOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 435);
            this.Controls.Add(this.fileTextOutput);
            this.Controls.Add(this.sparePositions);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.encBtn);
            this.Controls.Add(this.selFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selFile;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.TextBox sparePositions;
        private System.Windows.Forms.TextBox fileTextOutput;
    }
}

