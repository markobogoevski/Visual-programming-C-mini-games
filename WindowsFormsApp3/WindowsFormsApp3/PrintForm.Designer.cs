namespace WindowsFormsApp3
{
    partial class PrintForm
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
            this.lbDobivka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.columnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCoef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUplata = new System.Windows.Forms.Label();
            this.lbCoef = new System.Windows.Forms.Label();
            this.lbDanok = new System.Windows.Forms.Label();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playedMatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playedMatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDobivka
            // 
            this.lbDobivka.AutoSize = true;
            this.lbDobivka.Location = new System.Drawing.Point(489, 243);
            this.lbDobivka.Name = "lbDobivka";
            this.lbDobivka.Size = new System.Drawing.Size(35, 13);
            this.lbDobivka.TabIndex = 0;
            this.lbDobivka.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "FINKI BET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Уплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Коефициент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Добивка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Данок";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCode,
            this.columnMatch,
            this.columnCoef});
            this.dataGrid.Location = new System.Drawing.Point(175, 94);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(413, 119);
            this.dataGrid.TabIndex = 6;
            // 
            // columnCode
            // 
            this.columnCode.HeaderText = "Шифра";
            this.columnCode.Name = "columnCode";
            // 
            // columnMatch
            // 
            this.columnMatch.HeaderText = "Натпревар";
            this.columnMatch.Name = "columnMatch";
            // 
            // columnCoef
            // 
            this.columnCoef.HeaderText = "Коефициент";
            this.columnCoef.Name = "columnCoef";
            // 
            // lbUplata
            // 
            this.lbUplata.AutoSize = true;
            this.lbUplata.Location = new System.Drawing.Point(270, 243);
            this.lbUplata.Name = "lbUplata";
            this.lbUplata.Size = new System.Drawing.Size(35, 13);
            this.lbUplata.TabIndex = 0;
            this.lbUplata.Text = "label1";
            // 
            // lbCoef
            // 
            this.lbCoef.AutoSize = true;
            this.lbCoef.Location = new System.Drawing.Point(270, 272);
            this.lbCoef.Name = "lbCoef";
            this.lbCoef.Size = new System.Drawing.Size(35, 13);
            this.lbCoef.TabIndex = 7;
            this.lbCoef.Text = "label1";
            // 
            // lbDanok
            // 
            this.lbDanok.AutoSize = true;
            this.lbDanok.Location = new System.Drawing.Point(489, 272);
            this.lbDanok.Name = "lbDanok";
            this.lbDanok.Size = new System.Drawing.Size(35, 13);
            this.lbDanok.TabIndex = 8;
            this.lbDanok.Text = "label1";
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(WindowsFormsApp3.Match);
            // 
            // playedMatchBindingSource
            // 
            this.playedMatchBindingSource.DataSource = typeof(WindowsFormsApp3.PlayedMatch);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApp3.Form1);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDanok);
            this.Controls.Add(this.lbCoef);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUplata);
            this.Controls.Add(this.lbDobivka);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playedMatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDobivka;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.BindingSource playedMatchBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.Label lbUplata;
        private System.Windows.Forms.Label lbCoef;
        private System.Windows.Forms.Label lbDanok;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCoef;
    }
}