namespace WindowsFormsApp10
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCPU = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcMemory = new System.Diagnostics.PerformanceCounter();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.pbRAM = new System.Windows.Forms.ProgressBar();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCurrentLoad = new System.Windows.Forms.Label();
            this.lb10sAvg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mP";
            // 
            // pbCPU
            // 
            this.pbCPU.Location = new System.Drawing.Point(96, 59);
            this.pbCPU.Name = "pbCPU";
            this.pbCPU.Size = new System.Drawing.Size(341, 23);
            this.pbCPU.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcMemory
            // 
            this.pcMemory.CategoryName = "Memory";
            this.pcMemory.CounterName = "Available Bytes";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_Total";
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(96, 13);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(341, 23);
            this.pbRAM.TabIndex = 4;
            // 
            // timerBlink
            // 
            this.timerBlink.Enabled = true;
            this.timerBlink.Interval = 500;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 183);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "current load";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "10 sec. avg.";
            // 
            // lbCurrentLoad
            // 
            this.lbCurrentLoad.AutoSize = true;
            this.lbCurrentLoad.Location = new System.Drawing.Point(522, 22);
            this.lbCurrentLoad.Name = "lbCurrentLoad";
            this.lbCurrentLoad.Size = new System.Drawing.Size(63, 13);
            this.lbCurrentLoad.TabIndex = 8;
            this.lbCurrentLoad.Text = "current load";
            // 
            // lb10sAvg
            // 
            this.lb10sAvg.AutoSize = true;
            this.lb10sAvg.Location = new System.Drawing.Point(525, 69);
            this.lb10sAvg.Name = "lb10sAvg";
            this.lb10sAvg.Size = new System.Drawing.Size(63, 13);
            this.lb10sAvg.TabIndex = 9;
            this.lb10sAvg.Text = "current load";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 296);
            this.Controls.Add(this.lb10sAvg);
            this.Controls.Add(this.lbCurrentLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.pbCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pcMemory;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Windows.Forms.ProgressBar pbRAM;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurrentLoad;
        private System.Windows.Forms.Label lb10sAvg;
    }
}

