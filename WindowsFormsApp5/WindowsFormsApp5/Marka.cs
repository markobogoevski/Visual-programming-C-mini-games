using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Marka : Form
    {
        public NovaMarka novaMarka { get; set; }
        public Marka()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                novaMarka = new NovaMarka(textBox1.Text, textBox2.Text);
                DialogResult = DialogResult.OK;
            }
            else { 
            MessageBox.Show("You must enter all fields first!");
            return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
