using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    public partial class Form1 : Form
    {
        PolygonDoc polygons { get; set; }
        int mouseX { get; set; }
        int mouseY { get; set; }
        Color currentColor { get; set; }
        Polygon currentPolygon { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            newFile();
        }

        public void newFile()
        {
            currentPolygon = null;
            polygons = new PolygonDoc();
            currentColor = Color.Blue;
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "# Polygons : " + polygons.polygonNumber() + " " + mouseX + ", " + mouseY;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
            Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            polygons.draw(graphics);

            if (currentPolygon != null)
            {
                Point lastPoint = currentPolygon.getLastPoint();
                Pen pen = new Pen(Color.Black, 3);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                graphics.DrawLine(pen,lastPoint, new Point(mouseX, mouseY));
                if(currentPolygon.endCondition(new Point(mouseX, mouseY)))
                {
                    Rectangle rectangle = new Rectangle(currentPolygon.firstPoint.X - 5, currentPolygon.firstPoint.Y-5,
                        10, 10);
                    graphics.DrawRectangle(pen, rectangle);
                }
                pen.Dispose();
            }
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point clickLocation = e.Location;
                if (currentPolygon==null)
                {
                    currentPolygon = new Polygon(currentColor);
                    currentPolygon.addPoint(clickLocation);
                    polygons.addPolygon(currentPolygon);
                    Invalidate();
                }
                else
                {
                    //if ending polygon
                    if (currentPolygon.polygonPointCount() >= 3 &&
                        currentPolygon.endCondition(clickLocation))
                    {
                        currentPolygon.finishedDrawing = true;
                        Invalidate(true);
                        currentPolygon = null;
                    }
                    else
                    {
                        currentPolygon.addPoint(clickLocation);
                        Invalidate();
                    }
                }
            }
        }
    }
}
