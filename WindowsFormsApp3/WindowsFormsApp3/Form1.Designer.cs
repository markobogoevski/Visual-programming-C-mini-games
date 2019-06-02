namespace WindowsFormsApp3
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
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.lbBilten = new System.Windows.Forms.ListBox();
            this.lbTicket = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.btnAddInBilten = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbBiltenType = new System.Windows.Forms.ComboBox();
            this.tbCodeBilten = new System.Windows.Forms.TextBox();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudVlog = new System.Windows.Forms.NumericUpDown();
            this.tbDobivka = new System.Windows.Forms.TextBox();
            this.tbCoef = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVlog)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(30, 25);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTeams.Size = new System.Drawing.Size(196, 199);
            this.lbTeams.TabIndex = 0;
            this.lbTeams.SelectedIndexChanged += new System.EventHandler(this.lbTeams_SelectedIndexChanged);
            // 
            // lbBilten
            // 
            this.lbBilten.FormattingEnabled = true;
            this.lbBilten.Location = new System.Drawing.Point(232, 25);
            this.lbBilten.Name = "lbBilten";
            this.lbBilten.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbBilten.Size = new System.Drawing.Size(304, 199);
            this.lbBilten.TabIndex = 1;
            this.lbBilten.SelectedIndexChanged += new System.EventHandler(this.lbBilten_SelectedIndexChanged);
            // 
            // lbTicket
            // 
            this.lbTicket.FormattingEnabled = true;
            this.lbTicket.Location = new System.Drawing.Point(542, 25);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTicket.Size = new System.Drawing.Size(231, 199);
            this.lbTicket.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.btnAddNewTeam);
            this.groupBox1.Controls.Add(this.btnAddInBilten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(30, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Креирај билтен";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(115, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Избриши ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "1";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(35, 99);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 20;
            this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(35, 73);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(35, 47);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(55, 125);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(100, 20);
            this.tbCode.TabIndex = 17;
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(9, 179);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(100, 23);
            this.btnAddNewTeam.TabIndex = 16;
            this.btnAddNewTeam.Text = "Додади нов тим";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // btnAddInBilten
            // 
            this.btnAddInBilten.Location = new System.Drawing.Point(9, 150);
            this.btnAddInBilten.Name = "btnAddInBilten";
            this.btnAddInBilten.Size = new System.Drawing.Size(181, 23);
            this.btnAddInBilten.TabIndex = 15;
            this.btnAddInBilten.Text = "Додади во билтен";
            this.btnAddInBilten.UseVisualStyleBackColor = true;
            this.btnAddInBilten.Click += new System.EventHandler(this.btnAddInBilten_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Шифра";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Постави коефициенти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Избери 2 тима од иста држава";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbBiltenType);
            this.groupBox2.Controls.Add(this.tbCodeBilten);
            this.groupBox2.Controls.Add(this.btnAddMatch);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(232, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 208);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади натпревар во тикет";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(169, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Избриши натпревар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbBiltenType
            // 
            this.cbBiltenType.FormattingEnabled = true;
            this.cbBiltenType.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbBiltenType.Location = new System.Drawing.Point(9, 129);
            this.cbBiltenType.Name = "cbBiltenType";
            this.cbBiltenType.Size = new System.Drawing.Size(132, 21);
            this.cbBiltenType.TabIndex = 19;
            // 
            // tbCodeBilten
            // 
            this.tbCodeBilten.Location = new System.Drawing.Point(9, 74);
            this.tbCodeBilten.Name = "tbCodeBilten";
            this.tbCodeBilten.Size = new System.Drawing.Size(132, 20);
            this.tbCodeBilten.TabIndex = 18;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Location = new System.Drawing.Point(9, 179);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(129, 23);
            this.btnAddMatch.TabIndex = 17;
            this.btnAddMatch.Text = "Додади натпревар";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Избери тип";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Шифра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Избери натпревар од билтенот или внеси шифра:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudVlog);
            this.groupBox3.Controls.Add(this.tbDobivka);
            this.groupBox3.Controls.Add(this.tbCoef);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(542, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 208);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уплати тикет";
            // 
            // nudVlog
            // 
            this.nudVlog.Location = new System.Drawing.Point(18, 90);
            this.nudVlog.Name = "nudVlog";
            this.nudVlog.Size = new System.Drawing.Size(194, 20);
            this.nudVlog.TabIndex = 21;
            this.nudVlog.ValueChanged += new System.EventHandler(this.update);
            // 
            // tbDobivka
            // 
            this.tbDobivka.Enabled = false;
            this.tbDobivka.Location = new System.Drawing.Point(18, 139);
            this.tbDobivka.Name = "tbDobivka";
            this.tbDobivka.Size = new System.Drawing.Size(194, 20);
            this.tbDobivka.TabIndex = 20;
            // 
            // tbCoef
            // 
            this.tbCoef.Enabled = false;
            this.tbCoef.Location = new System.Drawing.Point(18, 32);
            this.tbCoef.Name = "tbCoef";
            this.tbCoef.Size = new System.Drawing.Size(194, 20);
            this.tbCoef.TabIndex = 19;
            this.tbCoef.TextChanged += new System.EventHandler(this.update);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(18, 165);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(194, 23);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Печати";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Добивка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Уплата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Вкупно коефициент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Листа на тимови";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Билтен";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тикет";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddNewTeam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbBilten);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Marko";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVlog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.ListBox lbBilten;
        private System.Windows.Forms.ListBox lbTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.Button btnAddInBilten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodeBilten;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudVlog;
        private System.Windows.Forms.TextBox tbDobivka;
        private System.Windows.Forms.TextBox tbCoef;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBiltenType;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

