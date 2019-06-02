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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 262);
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

    }
}

