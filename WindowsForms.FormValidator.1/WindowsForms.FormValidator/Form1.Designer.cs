namespace WindowsForms.FormValidator
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
            this.btnVnesi = new System.Windows.Forms.Button();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVozrast = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lablImePrezime = new System.Windows.Forms.Label();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbImePrezime = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnVnesi
            // 
            this.btnVnesi.Enabled = false;
            this.btnVnesi.Location = new System.Drawing.Point(47, 223);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(122, 33);
            this.btnVnesi.TabIndex = 23;
            this.btnVnesi.Text = "Внеси";
            this.btnVnesi.UseVisualStyleBackColor = true;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(76, 178);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(29, 13);
            this.lblKod.TabIndex = 22;
            this.lblKod.Text = "Код:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 13);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "е-пошта:";
            // 
            // lblVozrast
            // 
            this.lblVozrast.AutoSize = true;
            this.lblVozrast.Location = new System.Drawing.Point(53, 130);
            this.lblVozrast.Name = "lblVozrast";
            this.lblVozrast.Size = new System.Drawing.Size(52, 13);
            this.lblVozrast.TabIndex = 20;
            this.lblVozrast.Text = "Возраст:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(4, 104);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(101, 13);
            this.lblTel.TabIndex = 19;
            this.lblTel.Text = "Мобилен телефон:";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(71, 78);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(34, 13);
            this.lblGrad.TabIndex = 18;
            this.lblGrad.Text = "Град:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(58, 34);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(47, 13);
            this.lblAdresa.TabIndex = 17;
            this.lblAdresa.Text = "Адреса:";
            // 
            // lablImePrezime
            // 
            this.lablImePrezime.AutoSize = true;
            this.lablImePrezime.Location = new System.Drawing.Point(17, 11);
            this.lablImePrezime.Name = "lablImePrezime";
            this.lablImePrezime.Size = new System.Drawing.Size(88, 13);
            this.lablImePrezime.TabIndex = 16;
            this.lablImePrezime.Text = "Име и презиме:";
            // 
            // tbGrad
            // 
            this.tbGrad.AutoCompleteCustomSource.AddRange(new string[] {
            "Скопје",
            "Битола",
            "Куманово",
            "Тетово",
            "Охрид",
            "Прилеп",
            "Штип",
            "Струмица",
            "Кичево",
            "Крушево",
            "Радовиш",
            "Велес"});
            this.tbGrad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbGrad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbGrad.Location = new System.Drawing.Point(102, 75);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(95, 20);
            this.tbGrad.TabIndex = 26;
            // 
            // tbAdresa
            // 
            this.tbAdresa.AcceptsReturn = true;
            this.tbAdresa.Location = new System.Drawing.Point(102, 32);
            this.tbAdresa.MaxLength = 120;
            this.tbAdresa.Multiline = true;
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(95, 38);
            this.tbAdresa.TabIndex = 25;
            // 
            // tbImePrezime
            // 
            this.tbImePrezime.Location = new System.Drawing.Point(102, 8);
            this.tbImePrezime.MaxLength = 20;
            this.tbImePrezime.Name = "tbImePrezime";
            this.tbImePrezime.Size = new System.Drawing.Size(95, 20);
            this.tbImePrezime.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(103, 102);
            this.maskedTextBox1.Mask = "(999) 000-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(93, 20);
            this.maskedTextBox1.TabIndex = 27;
            this.maskedTextBox1.Text = "07";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 262);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbImePrezime);
            this.Controls.Add(this.btnVnesi);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblVozrast);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lablImePrezime);
            this.Name = "Form1";
            this.Text = "Форма за внес";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVozrast;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lablImePrezime;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbImePrezime;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

    }
}

