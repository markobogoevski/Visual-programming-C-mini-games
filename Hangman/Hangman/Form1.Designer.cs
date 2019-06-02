namespace Hangman
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
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wordGuess = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbWrongCounter = new System.Windows.Forms.ProgressBar();
            this.pbTimer = new System.Windows.Forms.ProgressBar();
            this.triedLetters = new System.Windows.Forms.TextBox();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walkthroughsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(506, 27);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(112, 42);
            this.time.TabIndex = 0;
            this.time.Text = "10:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игра";
            // 
            // wordGuess
            // 
            this.wordGuess.AutoSize = true;
            this.wordGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordGuess.Location = new System.Drawing.Point(12, 77);
            this.wordGuess.Name = "wordGuess";
            this.wordGuess.Size = new System.Drawing.Size(158, 55);
            this.wordGuess.TabIndex = 2;
            this.wordGuess.Text = "label1";
            // 
            // tbGuess
            // 
            this.tbGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuess.Location = new System.Drawing.Point(22, 163);
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(100, 62);
            this.tbGuess.TabIndex = 3;
            this.tbGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGuess.Location = new System.Drawing.Point(140, 162);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(103, 63);
            this.btnGuess.TabIndex = 4;
            this.btnGuess.Text = "OK";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.triedLetters);
            this.groupBox1.Location = new System.Drawing.Point(22, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Погодени букви";
            // 
            // pbWrongCounter
            // 
            this.pbWrongCounter.Location = new System.Drawing.Point(22, 379);
            this.pbWrongCounter.Name = "pbWrongCounter";
            this.pbWrongCounter.Size = new System.Drawing.Size(602, 23);
            this.pbWrongCounter.TabIndex = 6;
            // 
            // pbTimer
            // 
            this.pbTimer.Location = new System.Drawing.Point(22, 408);
            this.pbTimer.Name = "pbTimer";
            this.pbTimer.Size = new System.Drawing.Size(602, 23);
            this.pbTimer.TabIndex = 7;
            // 
            // triedLetters
            // 
            this.triedLetters.Enabled = false;
            this.triedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triedLetters.Location = new System.Drawing.Point(6, 20);
            this.triedLetters.Multiline = true;
            this.triedLetters.Name = "triedLetters";
            this.triedLetters.Size = new System.Drawing.Size(590, 59);
            this.triedLetters.TabIndex = 0;
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.adminsToolStripMenuItem,
            this.modsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guidesToolStripMenuItem,
            this.walkthroughsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // adminsToolStripMenuItem
            // 
            this.adminsToolStripMenuItem.Name = "adminsToolStripMenuItem";
            this.adminsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.adminsToolStripMenuItem.Text = "Admins";
            // 
            // modsToolStripMenuItem
            // 
            this.modsToolStripMenuItem.Name = "modsToolStripMenuItem";
            this.modsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.modsToolStripMenuItem.Text = "Mods";
            // 
            // guidesToolStripMenuItem
            // 
            this.guidesToolStripMenuItem.Name = "guidesToolStripMenuItem";
            this.guidesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guidesToolStripMenuItem.Text = "Guides";
            // 
            // walkthroughsToolStripMenuItem
            // 
            this.walkthroughsToolStripMenuItem.Name = "walkthroughsToolStripMenuItem";
            this.walkthroughsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.walkthroughsToolStripMenuItem.Text = "Walkthroughs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.pbTimer);
            this.Controls.Add(this.pbWrongCounter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.wordGuess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wordGuess;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox triedLetters;
        private System.Windows.Forms.ProgressBar pbWrongCounter;
        private System.Windows.Forms.ProgressBar pbTimer;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkthroughsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modsToolStripMenuItem;
    }
}

