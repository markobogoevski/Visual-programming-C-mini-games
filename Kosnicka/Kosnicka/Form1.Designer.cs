namespace Kosnicka
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbBag = new System.Windows.Forms.ListBox();
            this.btnClearProducts = new System.Windows.Forms.Button();
            this.btnClearBag = new System.Windows.Forms.Button();
            this.btnAddInBag = new System.Windows.Forms.Button();
            this.btnDeleteFromBag = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductCategory = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(28, 26);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbProducts.Size = new System.Drawing.Size(257, 329);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbBag
            // 
            this.lbBag.FormattingEnabled = true;
            this.lbBag.Location = new System.Drawing.Point(489, 26);
            this.lbBag.Name = "lbBag";
            this.lbBag.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbBag.Size = new System.Drawing.Size(257, 290);
            this.lbBag.TabIndex = 1;
            this.lbBag.SelectedIndexChanged += new System.EventHandler(this.lbBag_SelectedIndexChanged);
            // 
            // btnClearProducts
            // 
            this.btnClearProducts.Location = new System.Drawing.Point(28, 367);
            this.btnClearProducts.Name = "btnClearProducts";
            this.btnClearProducts.Size = new System.Drawing.Size(257, 23);
            this.btnClearProducts.TabIndex = 2;
            this.btnClearProducts.Text = "Ипсразни ја листата со продукти?";
            this.btnClearProducts.UseVisualStyleBackColor = true;
            this.btnClearProducts.Click += new System.EventHandler(this.btnClearProducts_Click);
            // 
            // btnClearBag
            // 
            this.btnClearBag.Location = new System.Drawing.Point(489, 367);
            this.btnClearBag.Name = "btnClearBag";
            this.btnClearBag.Size = new System.Drawing.Size(257, 23);
            this.btnClearBag.TabIndex = 3;
            this.btnClearBag.Text = "Ипсразни ја кошничката?";
            this.btnClearBag.UseVisualStyleBackColor = true;
            this.btnClearBag.Click += new System.EventHandler(this.btnClearBag_Click);
            // 
            // btnAddInBag
            // 
            this.btnAddInBag.Location = new System.Drawing.Point(302, 192);
            this.btnAddInBag.Name = "btnAddInBag";
            this.btnAddInBag.Size = new System.Drawing.Size(168, 23);
            this.btnAddInBag.TabIndex = 4;
            this.btnAddInBag.Text = "Додади во кошничката >>>";
            this.btnAddInBag.UseVisualStyleBackColor = true;
            this.btnAddInBag.Click += new System.EventHandler(this.btnAddInBag_Click);
            // 
            // btnDeleteFromBag
            // 
            this.btnDeleteFromBag.Enabled = false;
            this.btnDeleteFromBag.Location = new System.Drawing.Point(302, 221);
            this.btnDeleteFromBag.Name = "btnDeleteFromBag";
            this.btnDeleteFromBag.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteFromBag.TabIndex = 5;
            this.btnDeleteFromBag.Text = "Избриши од кошничката";
            this.btnDeleteFromBag.UseVisualStyleBackColor = true;
            this.btnDeleteFromBag.Click += new System.EventHandler(this.btnDeleteFromBag_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(302, 250);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(168, 23);
            this.btnAddNewProduct.TabIndex = 6;
            this.btnAddNewProduct.Text = "Додади нов продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(302, 279);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(168, 23);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Избриши продукт";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProductPrice);
            this.groupBox1.Controls.Add(this.tbProductCategory);
            this.groupBox1.Controls.Add(this.tbProductName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(302, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категорија:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена:";
            // 
            // tbProductName
            // 
            this.tbProductName.Enabled = false;
            this.tbProductName.Location = new System.Drawing.Point(6, 47);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(156, 20);
            this.tbProductName.TabIndex = 3;
            // 
            // tbProductCategory
            // 
            this.tbProductCategory.Enabled = false;
            this.tbProductCategory.Location = new System.Drawing.Point(6, 86);
            this.tbProductCategory.Name = "tbProductCategory";
            this.tbProductCategory.Size = new System.Drawing.Size(156, 20);
            this.tbProductCategory.TabIndex = 4;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(6, 125);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(100, 20);
            this.tbProductPrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Листа на продукти:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кошничка:";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(537, 332);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(209, 20);
            this.tbTotal.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Вкупно:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnDeleteFromBag);
            this.Controls.Add(this.btnAddInBag);
            this.Controls.Add(this.btnClearBag);
            this.Controls.Add(this.btnClearProducts);
            this.Controls.Add(this.lbBag);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbBag;
        private System.Windows.Forms.Button btnClearProducts;
        private System.Windows.Forms.Button btnClearBag;
        private System.Windows.Forms.Button btnAddInBag;
        private System.Windows.Forms.Button btnDeleteFromBag;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductCategory;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
    }
}

