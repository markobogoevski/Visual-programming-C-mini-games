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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StateAddcs newForm = new StateAddcs();
            DialogResult = newForm.ShowDialog();
            if (DialogResult == DialogResult.OK) 
                lbStates.Items.Add(newForm.state);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbStates.SelectedIndex!=-1)
            {
                lbStates.Items.RemoveAt(lbStates.SelectedIndex);
                btnDelete.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void lbStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStates.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
                btnChange.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnChange.Enabled = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (lbStates.SelectedIndex != -1) {
                StateAddcs newForm = new StateAddcs();
                DialogResult dialogResult = newForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    lbStates.Items.RemoveAt(lbStates.SelectedIndex);
                    lbStates.Items.Add(newForm.state);
                    }
        }
    }
}
