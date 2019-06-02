using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        private ulong TotalMem;
        public Form1()
        {
            InitializeComponent();
        TotalMem
            = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "System Monitor";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int load = (int)(pcMemory.NextValue()*100 / TotalMem);

            if (load > 75)
                pbRAM.ForeColor = Color.Yellow;
            if (load > 85)
                pbRAM.ForeColor = Color.Red;

            pbRAM.Value = 100 - load;
            pbCPU.Value = ((int)pcCPU.NextValue());

            if (pbRAM.Value > 80)
                timerBlink.Start();
            else
                timerBlink.Stop();
        }

        private void timerBlink_Tick(object sender, EventArgs e)
        {
            if (pbRAM.ForeColor != Color.Orange)
                pbRAM.ForeColor = Color.Orange;
            else
                pbRAM.ForeColor = Color.Red;
        }
    }
}
