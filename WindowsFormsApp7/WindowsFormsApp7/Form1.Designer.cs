﻿namespace WindowsFormsApp7
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
            this.lbConferences = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.btnAddConference = new System.Windows.Forms.Button();
            this.btnDeleteConference = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteConference);
            this.groupBox1.Controls.Add(this.btnAddConference);
            this.groupBox1.Controls.Add(this.comboBoxYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbConferences);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конференции";
            // 
            // lbConferences
            // 
            this.lbConferences.FormattingEnabled = true;
            this.lbConferences.Location = new System.Drawing.Point(17, 19);
            this.lbConferences.Name = "lbConferences";
            this.lbConferences.Size = new System.Drawing.Size(279, 290);
            this.lbConferences.TabIndex = 0;
            this.lbConferences.SelectedIndexChanged += new System.EventHandler(this.lbConferences_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Година";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(20, 341);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(276, 21);
            this.comboBoxYear.TabIndex = 2;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxYear_SelectedIndexChanged);
            // 
            // btnAddConference
            // 
            this.btnAddConference.Location = new System.Drawing.Point(17, 369);
            this.btnAddConference.Name = "btnAddConference";
            this.btnAddConference.Size = new System.Drawing.Size(279, 23);
            this.btnAddConference.TabIndex = 3;
            this.btnAddConference.Text = "Додади конференција";
            this.btnAddConference.UseVisualStyleBackColor = true;
            this.btnAddConference.Click += new System.EventHandler(this.btnAddConference_Click);
            // 
            // btnDeleteConference
            // 
            this.btnDeleteConference.Enabled = false;
            this.btnDeleteConference.Location = new System.Drawing.Point(17, 398);
            this.btnDeleteConference.Name = "btnDeleteConference";
            this.btnDeleteConference.Size = new System.Drawing.Size(279, 23);
            this.btnDeleteConference.TabIndex = 4;
            this.btnDeleteConference.Text = "Избриши конференција";
            this.btnDeleteConference.UseVisualStyleBackColor = true;
            this.btnDeleteConference.Click += new System.EventHandler(this.btnDeleteConference_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddConference;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteConference;
        private System.Windows.Forms.Button btnAddConference;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbConferences;
    }
}

