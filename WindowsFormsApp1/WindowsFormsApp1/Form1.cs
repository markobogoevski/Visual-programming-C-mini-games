using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
          
        }

        private void txtBoxAge_Validating(object sender, CancelEventArgs e)
        {
            int vozrast = int.Parse(txtBoxAge.Text);
            string message = "";

            if (!int.TryParse(txtBoxAge.Text, out vozrast) || vozrast < 1)
            {
                message = "Невалидна возраст!";
                e.Cancel = true;
                txtBoxAge.Select(0, txtBoxAge.TextLength);
                errorProviderAge.SetError(txtBoxAge, message);
            }
            else
                errorProviderAge.SetError(txtBoxAge, message);
        }

        private void txtBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtBoxEmail.Text;
            bool Validated = false;
            int index = -1;
            if ((index = email.IndexOf('@')) != -1)
            {
                for (int i = index + 1; i < email.Length; i++)
                    if (email[i] == '.')
                        Validated = true;
            }
            string message = "";
            if (!Validated)
            {
                e.Cancel = true;
                message = "Invalid email (must be appropriate format)!";
                errorProviderMail.SetError(txtBoxEmail, message);
            }
            else
                errorProviderMail.SetError(txtBoxEmail,message);
        }

        private void txtBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if(c!='\b' && !((c>='a'&&c<='f')||(c>='A'&&c<='F')||(c>='0'&&c<='9')))
                e.Handled = true;

            if (c >= 'a' && c <= 'f')
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting...");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnSubmit.Enabled)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUslovi formUslovi = new FormUslovi();
            formUslovi.ShowDialog();
        }

       
    }
}
