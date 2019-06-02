using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosnicka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            Нов_продукт нов_Продукт = new Нов_продукт();
            DialogResult result = нов_Продукт.ShowDialog();

            if (result == DialogResult.OK)
            {
                lbProducts.Items.Add(нов_Продукт.product);
            }


        }

        private void updateTotal()
        {
            decimal total = 0;
            foreach (Product product in lbBag.Items)
                total += product.Price;

            tbTotal.Text = total.ToString();
        }

        private void updateProduct()
        {
            if (lbProducts.SelectedIndex != -1)
            {
                Product product = (Product)lbProducts.SelectedItem;
                tbProductName.Text = product.Name;
                tbProductCategory.Text = product.Category;


                tbProductPrice.Text = String.Format("{0:0.00}", product.Price);
            }
            else
            {
                tbProductName.Clear();
                tbProductCategory.Clear();
                tbProductPrice.Clear(); 
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateProduct();
            if (lbProducts.SelectedIndex != -1)
                btnDeleteProduct.Enabled = true;
            else
                btnDeleteProduct.Enabled = false;
        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            if (lbProducts.Items.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", "Испразни ја листата?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lbProducts.Items.Clear();
                    updateProduct();
                    btnDeleteProduct.Enabled = false;
                }
            }
            else
                MessageBox.Show("Нема продукти во листата!");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(lbProducts.SelectedIndex!=-1)
            {
                lbProducts.Items.RemoveAt(lbProducts.SelectedIndex);
                updateProduct();
                btnDeleteProduct.Enabled = false;
            }
        }

        private void btnDeleteFromBag_Click(object sender, EventArgs e)
        {
            if (lbBag.SelectedIndex != -1)
            {
                lbBag.Items.RemoveAt(lbProducts.SelectedIndex);
                if (lbBag.SelectedIndex != -1)
                    btnDeleteFromBag.Enabled = true;
                else
                    btnDeleteFromBag.Enabled = false;
                updateTotal();
            }
        }

        private void lbBag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBag.SelectedIndex != -1)
                btnDeleteFromBag.Enabled = true;
        }

        private void btnAddInBag_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex != -1)
            {
                Product product = (Product)lbProducts.SelectedItem;
                lbBag.Items.Add(product);

                updateTotal();
            }
            else
                MessageBox.Show("Select the product you wish to add to the bag!");
        }

        private void btnClearBag_Click(object sender, EventArgs e)
        {
            if (lbBag.Items.Count != 0)
            {
                DialogResult dialog = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?", "Испразни ја кошничката?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    lbBag.Items.Clear();
                    updateTotal();
                    btnDeleteFromBag.Enabled = false;
                }
            }
            else
                MessageBox.Show("Нема продукти во кошничката!");
        }
    }
}
