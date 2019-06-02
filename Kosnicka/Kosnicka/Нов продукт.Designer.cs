namespace Kosnicka
{
    partial class Нов_продукт
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
            this.tbProductPriceAdd = new System.Windows.Forms.TextBox();
            this.tbProductCategoryAdd = new System.Windows.Forms.TextBox();
            this.tbProductNameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductPriceAdd
            // 
            this.tbProductPriceAdd.Location = new System.Drawing.Point(12, 105);
            this.tbProductPriceAdd.Name = "tbProductPriceAdd";
            this.tbProductPriceAdd.Size = new System.Drawing.Size(133, 20);
            this.tbProductPriceAdd.TabIndex = 2;
            this.tbProductPriceAdd.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductPriceAdd_Validating);
            // 
            // tbProductCategoryAdd
            // 
            this.tbProductCategoryAdd.Location = new System.Drawing.Point(12, 66);
            this.tbProductCategoryAdd.Name = "tbProductCategoryAdd";
            this.tbProductCategoryAdd.Size = new System.Drawing.Size(236, 20);
            this.tbProductCategoryAdd.TabIndex = 1;
            this.tbProductCategoryAdd.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductCategoryAdd_Validating);
            // 
            // tbProductNameAdd
            // 
            this.tbProductNameAdd.Location = new System.Drawing.Point(12, 27);
            this.tbProductNameAdd.Name = "tbProductNameAdd";
            this.tbProductNameAdd.Size = new System.Drawing.Size(236, 20);
            this.tbProductNameAdd.TabIndex = 0;
            this.tbProductNameAdd.Validating += new System.ComponentModel.CancelEventHandler(this.tbProductNameAdd_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Категорија:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Име:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(92, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Нов_продукт
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 163);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbProductPriceAdd);
            this.Controls.Add(this.tbProductCategoryAdd);
            this.Controls.Add(this.tbProductNameAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Нов_продукт";
            this.Text = "Нов_продукт";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductPriceAdd;
        private System.Windows.Forms.TextBox tbProductCategoryAdd;
        private System.Windows.Forms.TextBox tbProductNameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}