namespace Aerodromi
{
    partial class Nova_destinacija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudDestinationPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDestinationLen = new System.Windows.Forms.NumericUpDown();
            this.btnCancelDestination = new System.Windows.Forms.Button();
            this.btnSubmitDestination = new System.Windows.Forms.Button();
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudDestinationPrice);
            this.groupBox1.Controls.Add(this.nudDestinationLen);
            this.groupBox1.Controls.Add(this.btnCancelDestination);
            this.groupBox1.Controls.Add(this.btnSubmitDestination);
            this.groupBox1.Controls.Add(this.tbDestinationName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 179);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади дестинација";
            // 
            // nudDestinationPrice
            // 
            this.nudDestinationPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDestinationPrice.Location = new System.Drawing.Point(21, 123);
            this.nudDestinationPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDestinationPrice.Name = "nudDestinationPrice";
            this.nudDestinationPrice.Size = new System.Drawing.Size(120, 20);
            this.nudDestinationPrice.TabIndex = 8;
            // 
            // nudDestinationLen
            // 
            this.nudDestinationLen.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDestinationLen.Location = new System.Drawing.Point(21, 81);
            this.nudDestinationLen.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDestinationLen.Name = "nudDestinationLen";
            this.nudDestinationLen.Size = new System.Drawing.Size(120, 20);
            this.nudDestinationLen.TabIndex = 7;
            // 
            // btnCancelDestination
            // 
            this.btnCancelDestination.Location = new System.Drawing.Point(148, 149);
            this.btnCancelDestination.Name = "btnCancelDestination";
            this.btnCancelDestination.Size = new System.Drawing.Size(97, 23);
            this.btnCancelDestination.TabIndex = 6;
            this.btnCancelDestination.Text = "Откажи";
            this.btnCancelDestination.UseVisualStyleBackColor = true;
            this.btnCancelDestination.Click += new System.EventHandler(this.btnCancelDestination_Click);
            // 
            // btnSubmitDestination
            // 
            this.btnSubmitDestination.Location = new System.Drawing.Point(21, 149);
            this.btnSubmitDestination.Name = "btnSubmitDestination";
            this.btnSubmitDestination.Size = new System.Drawing.Size(97, 23);
            this.btnSubmitDestination.TabIndex = 5;
            this.btnSubmitDestination.Text = "Додади";
            this.btnSubmitDestination.UseVisualStyleBackColor = true;
            this.btnSubmitDestination.Click += new System.EventHandler(this.btnSubmitDestination_Click);
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.Location = new System.Drawing.Point(21, 42);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(237, 20);
            this.tbDestinationName.TabIndex = 3;
            this.tbDestinationName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestinationName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должина";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nova_destinacija
            // 
            this.AcceptButton = this.btnSubmitDestination;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nova_destinacija";
            this.Text = "Nova_destinacija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDestinationPrice;
        private System.Windows.Forms.NumericUpDown nudDestinationLen;
        private System.Windows.Forms.Button btnCancelDestination;
        private System.Windows.Forms.Button btnSubmitDestination;
        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}