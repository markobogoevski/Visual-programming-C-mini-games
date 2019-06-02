using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsValidating1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbVozrast_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int vozrast;
            if (!int.TryParse(tbVozrast.Text, out vozrast) || vozrast < 1)
            {
                // Set the error message
                errorMsg = "Невалидна возраст";
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tbVozrast.Select(0, tbVozrast.Text.Length);
                // Set the ErrorProvider error with the text to display. 
                errorProviderVozrast.SetError(tbVozrast, errorMsg);
            }
            else
                errorProviderVozrast.SetError(tbVozrast, "");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(tbEmail.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                //textBoxMail.Select(0, textBoxMail.Text.Length);
                // Set the ErrorProvider error with the text to display. 
                errorProviderEmail.SetError(tbEmail, errorMsg);
            }
            else
                errorProviderEmail.SetError(tbEmail, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            int atpos;
            if ((atpos=emailAddress.IndexOf("@")) > -1)
            {
                if (emailAddress.IndexOf(".", atpos) > atpos && emailAddress.IndexOf("@", atpos+1) <= atpos)
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "e-mail адресата мора да биде во валиден формат \n" +
                "На пример: 'someone@example.com' ";
            return false;
        }

        private void tbKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c != '\b' && !((c >= 'a' && c <= 'f') || (c <= 'F' && c >= 'A') || (c >= '0' && c <= '9')))
            {
                e.Handled = true;
            }
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting...");
            this.Close();
        }

        private void cbUslovi_CheckedChanged(object sender, EventArgs e)
        {
            btnVnesi.Enabled = cbUslovi.Checked;
        }

        private void linkUslovi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUslovi formUslovi = new FormUslovi();
            formUslovi.ShowDialog();
//            FormBrowser formUslovi = new FormBrowser();
//            formUslovi.ShowDialog();
        }
    }
}
