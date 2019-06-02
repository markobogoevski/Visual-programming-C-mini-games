namespace WindowsFormsApp2
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
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxConfirm = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTopSomething = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(425, 43);
            this.lbSongs.MultiColumn = true;
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(346, 290);
            this.lbSongs.Sorted = true;
            this.lbSongs.TabIndex = 0;
            this.lbSongs.TabStop = false;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Song duration(in seconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // checkBoxConfirm
            // 
            this.checkBoxConfirm.AutoSize = true;
            this.checkBoxConfirm.Location = new System.Drawing.Point(287, 198);
            this.checkBoxConfirm.Name = "checkBoxConfirm";
            this.checkBoxConfirm.Size = new System.Drawing.Size(67, 17);
            this.checkBoxConfirm.TabIndex = 4;
            this.checkBoxConfirm.Text = "Confirm?";
            this.checkBoxConfirm.UseVisualStyleBackColor = true;
            this.checkBoxConfirm.CheckedChanged += new System.EventHandler(this.checkBoxConfirm_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(267, 245);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 44);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Insert";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(267, 43);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 6;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(267, 143);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(100, 20);
            this.tbRating.TabIndex = 7;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(247, 93);
            this.numDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(140, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTopSomething
            // 
            this.lblTopSomething.AutoSize = true;
            this.lblTopSomething.Location = new System.Drawing.Point(425, 352);
            this.lblTopSomething.Name = "lblTopSomething";
            this.lblTopSomething.Size = new System.Drawing.Size(77, 13);
            this.lblTopSomething.TabIndex = 10;
            this.lblTopSomething.Tag = "Top something";
            this.lblTopSomething.Text = "Top something";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTopSomething);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.checkBoxConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSongs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxConfirm;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTopSomething;
    }
}

