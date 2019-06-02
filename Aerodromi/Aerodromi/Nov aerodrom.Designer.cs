namespace Aerodromi
{
    partial class Nov_aerodrom
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelAirport = new System.Windows.Forms.Button();
            this.btnSubmitAirport = new System.Windows.Forms.Button();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.tbAbbr = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Град";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кратенка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelAirport);
            this.groupBox1.Controls.Add(this.btnSubmitAirport);
            this.groupBox1.Controls.Add(this.tbAirportName);
            this.groupBox1.Controls.Add(this.tbCityName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            // 
            // btnCancelAirport
            // 
            this.btnCancelAirport.Location = new System.Drawing.Point(148, 149);
            this.btnCancelAirport.Name = "btnCancelAirport";
            this.btnCancelAirport.Size = new System.Drawing.Size(97, 23);
            this.btnCancelAirport.TabIndex = 3;
            this.btnCancelAirport.Text = "Откажи";
            this.btnCancelAirport.UseVisualStyleBackColor = true;
            this.btnCancelAirport.Click += new System.EventHandler(this.btnCancelAirport_Click);
            // 
            // btnSubmitAirport
            // 
            this.btnSubmitAirport.Location = new System.Drawing.Point(21, 149);
            this.btnSubmitAirport.Name = "btnSubmitAirport";
            this.btnSubmitAirport.Size = new System.Drawing.Size(97, 23);
            this.btnSubmitAirport.TabIndex = 1;
            this.btnSubmitAirport.Text = "Зачувај";
            this.btnSubmitAirport.UseVisualStyleBackColor = true;
            this.btnSubmitAirport.Click += new System.EventHandler(this.btnSubmitAirport_Click);
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(21, 81);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(237, 20);
            this.tbAirportName.TabIndex = 2;
            this.tbAirportName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportName_Validating);
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(21, 42);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(237, 20);
            this.tbCityName.TabIndex = 5;
            this.tbCityName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityName_Validating);
            // 
            // tbAbbr
            // 
            this.tbAbbr.Location = new System.Drawing.Point(33, 135);
            this.tbAbbr.Name = "tbAbbr";
            this.tbAbbr.Size = new System.Drawing.Size(97, 20);
            this.tbAbbr.TabIndex = 1;
            this.tbAbbr.Validating += new System.ComponentModel.CancelEventHandler(this.tbAbbr_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Nov_aerodrom
            // 
            this.AcceptButton = this.btnSubmitAirport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 203);
            this.Controls.Add(this.tbAbbr);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nov_aerodrom";
            this.Text = "Nov_aerodrom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelAirport;
        private System.Windows.Forms.Button btnSubmitAirport;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.TextBox tbAbbr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}