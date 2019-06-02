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
    public partial class Нов_продукт : Form
    {
        public Product product { get; set; }
        public Нов_продукт()
        {
            InitializeComponent();
        }

        private void tbProductNameAdd_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbProductNameAdd.Text.Trim().Length == 0||!allLetters(tbProductNameAdd))
            {
                message = "You must add the product name! (no numbers allowed)";
                errorProvider1.SetError(tbProductNameAdd, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbProductNameAdd, null);
        }

        private void tbProductCategoryAdd_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbProductCategoryAdd.Text.Trim().Length == 0||!allLetters(tbProductCategoryAdd))
            {
                message = "You must add the product category! (no numbers allowed)";
                errorProvider1.SetError(tbProductCategoryAdd, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbProductCategoryAdd, null);
        }

        private bool allLetters(TextBox tb)
        {
            for (int i = 0; i < tb.Text.Length; i++)
                if (!char.IsLetter(tb.Text[i]))
                    return false;

            return true;
        }

        private void tbProductPriceAdd_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbProductPriceAdd.Text.Trim().Length == 0||!allNumbers(tbProductPriceAdd))
            {
                message = "You must add the product price (only numbers)!";
                errorProvider1.SetError(tbProductPriceAdd, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbProductPriceAdd, null);
        }

        //Helper function
        private bool allNumbers(TextBox tb)
        {
            for (int i = 0; i < tb.Text.Length; i++)
                if (!char.IsNumber(tb.Text[i])&&(!tb.Text[i].Equals(".")&&!tb.Text[i].Equals(",")))
                    return false;

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbProductCategoryAdd.Text.Length != 0 && tbProductNameAdd.Text.Length != 0 && tbProductPriceAdd.Text.Length != 0)
            {
                DialogResult = DialogResult.OK;
                decimal price;
                decimal.TryParse(tbProductPriceAdd.Text, out price);

                product = new Product(tbProductNameAdd.Text, tbProductCategoryAdd.Text, price);
            }
            else
            {
                MessageBox.Show("Enter all fields!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
