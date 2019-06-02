using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = System.Environment.MachineName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblMemory.Text = (pcMemory.NextValue()/1000).ToString("#,000");
            lblCpu.Text = pcCPU.NextValue().ToString("0.0%" +
                "");
        }
        static int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.FillRectangle(new SolidBrush(Color.Black), this.ClientRectangle);
            graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(20+count, 20+count, 50, 50));
            count++;
        }
    }
}
