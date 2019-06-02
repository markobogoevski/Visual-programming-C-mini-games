namespace WindowsFormsApp6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbWords = new System.Windows.Forms.CheckedListBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMaxChars = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbMessage);
            this.groupBox1.Controls.Add(this.lblMaxChars);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова порака";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddWord);
            this.groupBox2.Controls.Add(this.clbWords);
            this.groupBox2.Location = new System.Drawing.Point(465, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стоп порака";
            // 
            // clbWords
            // 
            this.clbWords.CheckOnClick = true;
            this.clbWords.FormattingEnabled = true;
            this.clbWords.Location = new System.Drawing.Point(6, 21);
            this.clbWords.Name = "clbWords";
            this.clbWords.Size = new System.Drawing.Size(217, 244);
            this.clbWords.TabIndex = 0;
            this.clbWords.SelectedIndexChanged += new System.EventHandler(this.clbWords_SelectedIndexChanged);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(6, 275);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(217, 23);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Додади нов";
            this.btnAddWord.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(298, 275);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Испрати";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMaxChars
            // 
            this.lblMaxChars.AutoSize = true;
            this.lblMaxChars.Location = new System.Drawing.Point(21, 276);
            this.lblMaxChars.Name = "lblMaxChars";
            this.lblMaxChars.Size = new System.Drawing.Size(25, 13);
            this.lblMaxChars.TabIndex = 3;
            this.lblMaxChars.Text = "125";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(24, 20);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(364, 245);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaxChars;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.CheckedListBox clbWords;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

