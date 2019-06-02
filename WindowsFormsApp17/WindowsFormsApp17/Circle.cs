using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    [Serializable]
    public class Circle
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Radius { get; set; }
        public bool selected { get; set; }
        public bool secondClicked { get; set; }
        public int Velocity { get; set; }
        public Color color { get; set; }

        public Circle(int xCoord, int yCoord,Color color)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            this.color = color;
            Velocity = 10;
        }

        public void setRadius(int Radius)
        {
            this.Radius = Radius;
        }

        public void select()
        {
            if (selected)
                selected = false;
            else
                selected = true;
        }

      

        public void draw(Graphics g)
        {
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            if (secondClicked)
            {
                Brush brush = new SolidBrush(color);
                g.FillEllipse(brush, rectangle);
                if (selected)
                {
                    Pen pen = new Pen(Color.Red,4);
                    g.DrawEllipse(pen, rectangle);
                    pen.Dispose();
                }
                brush.Dispose();
            }
            else
            {
                Pen pen = new Pen(Color.Black,4);
                pen.DashStyle=DashStyle.Dot;
                pen.DashOffset = 2f;
                g.DrawEllipse(pen, rectangle);
                pen.Dispose();
            }
        }
    }
}
