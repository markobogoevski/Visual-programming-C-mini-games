using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud1WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbAge_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            int age;

            if (!(int.TryParse(tbAge.Text, out age)) || age < 1)
            {
                e.Cancel = true;
                message = "You must enter age in number and it must be >=1!";
                errorAge.SetError(tbAge, message);
            }
            else
                errorAge.SetError(tbAge, message);
        }

        private void tbMail_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            string email = tbMail.Text;

            if (!validEmail(email, out message))
            {
                e.Cancel = true;
                errorEmail.SetError(tbMail, message);
            }
            else
                errorEmail.SetError(tbMail, message);
        }

        private bool validEmail(string email,out string message)
        {
           if(email.Length<=0)
            {
                message = "Email mustn't be empty!";
                return false;
            }
           else
            {
                int index = -1;
                if((index=email.IndexOf("@"))!=-1)
                {
                    for (int i = index + 1; i < email.Length; i++)
                        if (email.ElementAt(i) == '.')
                        {
                            message = "";
                            return true;
                        }

                    message = "Email must contain '.' after '@' !";
                    return false;
                }
                else
                {
                    message = "Email must contain '@'";
                    return false;
                }
            }
        }

        private void tbCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;

            if (key != '\b' && !((key >= 'a' && key <= 'f') || (key >= 'A' && key <= 'F') || (key >= '0' && key <= '9')))
                e.Handled = true;

            if (key >= 'a' && key <= 'f')
                e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting app...");
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!button1.Enabled)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUslovi2 formUslovi2= new FormUslovi2();
            formUslovi2.ShowDialog();
        }
    }
}
