namespace WindowsFormsValidating1
{
    partial class FormUslovi
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
            this.tbUslovi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUslovi
            // 
            this.tbUslovi.AcceptsReturn = true;
            this.tbUslovi.Location = new System.Drawing.Point(6, 6);
            this.tbUslovi.Multiline = true;
            this.tbUslovi.Name = "tbUslovi";
            this.tbUslovi.ReadOnly = true;
            this.tbUslovi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUslovi.Size = new System.Drawing.Size(211, 111);
            this.tbUslovi.TabIndex = 0;
            this.tbUslovi.TabStop = false;
            // 
            // FormUslovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 121);
            this.Controls.Add(this.tbUslovi);
            this.Name = "FormUslovi";
            this.Text = "FormUslovi";
            this.Load += new System.EventHandler(this.FormUslovi_Load);
            this.Resize += new System.EventHandler(this.FormUslovi_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUslovi;
    }
}