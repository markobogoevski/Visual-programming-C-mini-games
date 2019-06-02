using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        
        public shapeType type { get; set; }
        public ShapeList shapes { get; set; }
        public Color color { get; set; }
        public Shape selectedShape { get; set; }
        public bool mouseHold { get; set; }


        public Form1()
        {
            color = Color.Green;
            shapes = new ShapeList();
            type = shapeType.CIRCLE;
            InitializeComponent();
            mouseHold = false;
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            shapes.bounce();
            Invalidate();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            if (sender == circleToolStripMenuItem)
            {
                type = shapeType.CIRCLE;
                circleToolStripMenuItem.Checked = true;
                squareToolStripMenuItem.Checked = false;
            }
            else
            {
                type = shapeType.SQUARE;
                circleToolStripMenuItem.Checked = false;
                squareToolStripMenuItem.Checked = true;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            DialogResult result = colorPicker.ShowDialog();
            if(result==DialogResult.OK)
            {
                color = colorPicker.Color;
            }
        }

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            shapes.draw(g);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            shapes.addShape(clickLocation,color, type);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            shapes.clearSelected();
            shapes.selectedShape(e.Location);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseHold = true;
            shapes.clearSelected();
            selectedShape=shapes.selectedShape(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHold = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHold && selectedShape != null)
            {
                selectedShape.move(e.Location);
            }
            Invalidate();
        }
    }
}
