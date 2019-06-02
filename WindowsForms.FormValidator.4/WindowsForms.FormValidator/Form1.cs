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
    }
}
