namespace Lab6
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbFirstOperand = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbSecondOperand = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnBestPlayers = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.pbPoints = new System.Windows.Forms.ProgressBar();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeCount = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поени :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Преостанато време :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(98, 19);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbFirstOperand
            // 
            this.tbFirstOperand.Enabled = false;
            this.tbFirstOperand.Location = new System.Drawing.Point(38, 55);
            this.tbFirstOperand.Name = "tbFirstOperand";
            this.tbFirstOperand.Size = new System.Drawing.Size(85, 20);
            this.tbFirstOperand.TabIndex = 4;
            // 
            // tbOperator
            // 
            this.tbOperator.Enabled = false;
            this.tbOperator.Location = new System.Drawing.Point(166, 55);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(50, 20);
            this.tbOperator.TabIndex = 5;
            // 
            // tbSecondOperand
            // 
            this.tbSecondOperand.Enabled = false;
            this.tbSecondOperand.Location = new System.Drawing.Point(258, 55);
            this.tbSecondOperand.Name = "tbSecondOperand";
            this.tbSecondOperand.Size = new System.Drawing.Size(85, 20);
            this.tbSecondOperand.TabIndex = 6;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(428, 55);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(98, 20);
            this.tbResult.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "=";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(567, 55);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 9;
            this.btnGuess.Text = "Погоди";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(38, 225);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(97, 23);
            this.btnNewGame.TabIndex = 10;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnBestPlayers
            // 
            this.btnBestPlayers.Location = new System.Drawing.Point(245, 225);
            this.btnBestPlayers.Name = "btnBestPlayers";
            this.btnBestPlayers.Size = new System.Drawing.Size(151, 23);
            this.btnBestPlayers.TabIndex = 11;
            this.btnBestPlayers.Text = "Најдобри играчи";
            this.btnBestPlayers.UseVisualStyleBackColor = true;
            this.btnBestPlayers.Click += new System.EventHandler(this.btnBestPlayers_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(567, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Исклучи";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(38, 184);
            this.pbTime.Maximum = 60;
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(604, 23);
            this.pbTime.Step = 1;
            this.pbTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTime.TabIndex = 13;
            // 
            // pbPoints
            // 
            this.pbPoints.Location = new System.Drawing.Point(38, 122);
            this.pbPoints.Name = "pbPoints";
            this.pbPoints.Size = new System.Drawing.Size(604, 23);
            this.pbPoints.Step = 1;
            this.pbPoints.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPoints.TabIndex = 14;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(95, 94);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPoints.TabIndex = 15;
            this.lblPoints.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(163, 158);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "00:00";
            // 
            // timeCount
            // 
            this.timeCount.Interval = 1000;
            this.timeCount.Tick += new System.EventHandler(this.timeCount_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 271);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.pbPoints);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBestPlayers);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSecondOperand);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbFirstOperand);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbFirstOperand;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbSecondOperand;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnBestPlayers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.ProgressBar pbPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timeCount;
    }
}

