using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public int type { get; set; }
        public Color color { get; set; }
        public Shape selectedShape { get; set; }
        public ListShape listShape { get; set; }
        public bool mouseHold { get; set; }
         
        public Form1()
        {
            InitializeComponent();
            selectedShape = null;
            color = Color.Green;
            listShape = new ListShape();
            this.DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            listShape.addShape(color, clickLocation, type);
            Invalidate();
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            listShape.clearSelected();
            mouseHold = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
            listShape.clearSelected();
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (mouseHold)
            {
                selectedShape = listShape.select(e.Location);
                if (selectedShape != null)
                {
                    selectedShape.move(e.Location);
                    Invalidate();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            listShape.draw(graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listShape.shapeList.Count != 0)
            {
                listShape.bounce();
                Invalidate();
            }
        }

        private void menuItemClick(object sender, EventArgs e)
        {
            if (sender == circleToolStripMenuItem)
            {
                type = 1;
                circleToolStripMenuItem.Checked = true;
                rectangleToolStripMenuItem.Checked = false;
            }
            else
            {
                type = 2;
                circleToolStripMenuItem.Checked = false;
                rectangleToolStripMenuItem.Checked = true;
            }
        }
    }
}
