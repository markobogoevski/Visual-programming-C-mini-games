using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class StateAddcs : Form
    {
        public State state { get; set; }
        public StateAddcs()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (tbName.Text.Length == 0)
            {
                message = "The name of country mustnt be empty!";
                errorProvider1.SetError(tbName, message);
                e.Cancel = true;
            }
            errorProvider1.SetError(tbName, message);
        }

        private void mtbAbbr_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (mtbAbbr.Text.Length != 2)
            {
                message = "The abbreviation must be exactly 2 letters!";
                errorProvider1.SetError(mtbAbbr, message);
                e.Cancel = true;
            }
            errorProvider1.SetError(mtbAbbr, message);
        }

        private void tbCapital_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (tbCapital.Text.Length == 0)
            {
                message = "The name of capital mustnt be empty!";
                errorProvider1.SetError(tbCapital, message);
                e.Cancel = true;
            }
            errorProvider1.SetError(tbCapital, message);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("You must enter all fields!");
                return;
            }
            else
            {
                state = new State(tbName.Text, mtbAbbr.Text, tbCapital.Text);
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
