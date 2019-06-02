using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnRefresh_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbMemoryValue.Text = pcMemory.NextValue().ToString("#,000");
            lbCPUUsage.Text = String.Format("{0:0.00}", pcCPU.NextValue());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnRefresh_Click(null,null);
        }
    }
}
