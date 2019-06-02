using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class AddDriver : Form
    {
        public Driver driver { get; set; }
        public AddDriver()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (textBox1.Text.Length == 0)
            {
                message = "Field must not be empty!";
                errorProvider1.SetError(textBox1, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBox1, message);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }
            else
            {
                driver = new Driver(textBox1.Text, (int)numericUpDown1.Value, checkBox1.Checked);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
