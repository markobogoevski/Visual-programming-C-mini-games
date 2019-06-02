using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms.FormValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbVozrast_Validating(object sender, CancelEventArgs e)
        {
            int vozrast;
            if (!int.TryParse(tbVozrast.Text, out vozrast) || vozrast < 1)
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                tbVozrast.Select(0, tbVozrast.Text.Length);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
