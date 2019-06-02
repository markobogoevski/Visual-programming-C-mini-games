using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodromi
{
    public partial class Nova_destinacija : Form
    {
        public Destination destination { get; set; }
        public Nova_destinacija()
        {
            InitializeComponent();
        }

        private void tbDestinationName_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbDestinationName.Text.Length == 0)
            {
                message = "Destination name mustn't be empty!";
                errorProvider1.SetError(tbDestinationName, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbDestinationName, "");
        }

        private void btnSubmitDestination_Click(object sender, EventArgs e)
        {
            if(tbDestinationName.Text.Length!=0)
            {
                destination = new Destination(tbDestinationName.Text, nudDestinationLen.Value, nudDestinationPrice.Value);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelDestination_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
