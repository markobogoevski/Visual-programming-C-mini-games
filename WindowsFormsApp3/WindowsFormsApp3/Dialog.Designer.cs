namespace WindowsFormsApp3
{
    partial class Dialog
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
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.tbCityName = new System.Windows.Forms.TextBox();
            this.btnEnterTeam = new System.Windows.Forms.Button();
            this.btnCancelTeam = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на тим";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Град";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(36, 39);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(206, 20);
            this.tbTeamName.TabIndex = 2;
            this.tbTeamName.Validating += new System.ComponentModel.CancelEventHandler(this.tbTeamName_Validating);
            // 
            // tbCityName
            // 
            this.tbCityName.Location = new System.Drawing.Point(36, 83);
            this.tbCityName.Name = "tbCityName";
            this.tbCityName.Size = new System.Drawing.Size(206, 20);
            this.tbCityName.TabIndex = 3;
            this.tbCityName.Validating += new System.ComponentModel.CancelEventHandler(this.tbCityName_Validating);
            // 
            // btnEnterTeam
            // 
            this.btnEnterTeam.Location = new System.Drawing.Point(36, 124);
            this.btnEnterTeam.Name = "btnEnterTeam";
            this.btnEnterTeam.Size = new System.Drawing.Size(100, 23);
            this.btnEnterTeam.TabIndex = 4;
            this.btnEnterTeam.Text = "OK";
            this.btnEnterTeam.UseVisualStyleBackColor = true;
            this.btnEnterTeam.Click += new System.EventHandler(this.btnEnterTeam_Click);
            // 
            // btnCancelTeam
            // 
            this.btnCancelTeam.Location = new System.Drawing.Point(142, 124);
            this.btnCancelTeam.Name = "btnCancelTeam";
            this.btnCancelTeam.Size = new System.Drawing.Size(100, 23);
            this.btnCancelTeam.TabIndex = 5;
            this.btnCancelTeam.Text = "Cancel";
            this.btnCancelTeam.UseVisualStyleBackColor = true;
            this.btnCancelTeam.Click += new System.EventHandler(this.btnCancelTeam_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Dialog
            // 
            this.AcceptButton = this.btnEnterTeam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(270, 160);
            this.Controls.Add(this.btnCancelTeam);
            this.Controls.Add(this.btnEnterTeam);
            this.Controls.Add(this.tbCityName);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.TextBox tbCityName;
        private System.Windows.Forms.Button btnEnterTeam;
        private System.Windows.Forms.Button btnCancelTeam;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}