using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Blue, 2);
            g.FillEllipse(solidBrush, this.ClientRectangle);
            g.DrawEllipse(pen, this.ClientRectangle);
            solidBrush.Dispose();
            pen.Dispose();
        }

      

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point(50, 1000);
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }
    }
}
