using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCircles
{
    public partial class Form1 : Form
    {
        CircleList circles { get; set; }
        Color currentColor { get; set; }
        bool firstClick { get; set; }
        bool secondClick { get; set; }
        Circle currentExpanding { get; set; }

        public Form1()
        {
            secondClick = true;
            circles = new CircleList();
            currentColor = Color.Green;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = dialog.Color;
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            if (e.Button == MouseButtons.Left)
            { 
                if (secondClick)
                {
                    secondClick = false;
                    firstClick = true;
                    Circle newCircle = new Circle(clickLocation.X, clickLocation.Y, currentColor);
                    newCircle.secondClicked = false;
                    circles.addCircle(newCircle);
                    currentExpanding = newCircle;
                }
                else if (firstClick)
                {
                    firstClick = false;
                    secondClick = true;
                    currentExpanding.secondClicked = true;
                    Invalidate();
                }

            }
            if(e.Button == MouseButtons.Right)
            {
                circles.selectCircle(clickLocation);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            lblCircle.Text = "Circles : " + circles.drawn();
            circles.draw(graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (firstClick&&currentExpanding!=null)
            {
                Point mouseLocation = e.Location;
                int distance = (int)(Math.Sqrt(Math.Pow(currentExpanding.XCoord - mouseLocation.X, 2)+Math.Pow(currentExpanding.YCoord - mouseLocation.Y, 2)));
                currentExpanding.setRadius(distance);
                Invalidate();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (firstClick)
                {
                    circles.deleteCircle(currentExpanding);
                    currentExpanding = null;
                    firstClick = false;
                    secondClick = true;
                    Invalidate();
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                circles.deleteAll();
                Invalidate();
            }
        }
    }
}
