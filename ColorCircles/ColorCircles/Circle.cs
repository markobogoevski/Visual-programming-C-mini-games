using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    class Circle
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        int Radius { get; set; }
        bool Selected { get; set; }
        public bool secondClicked { get; set; }
        Color color { get; set; }

        public Circle(int xCoord, int yCoord,Color color)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            Selected = false;
            secondClicked = false;
            this.color = color;
        }

        public void setRadius(int Radius)
        {
            this.Radius = Radius;
        }

        public bool select(Point clickPoint)
        {
            
                int distance = (int)(Math.Sqrt(Math.Pow(clickPoint.X - XCoord, 2) + Math.Pow(clickPoint.Y - YCoord, 2)));

                if (distance <= Radius)
                {
                if (!Selected)
                {
                    Selected = true;
                    return true;
                }
                else
                {
                    Selected = false;
                    return false;
                }
                }
            return false;
        }

        public void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            if (secondClicked)
            {
                g.FillEllipse(brush, rectangle);
                if (Selected)
                {
                    Pen pen = new Pen(Color.Red, 5);
                    g.DrawEllipse(pen, rectangle);
                    pen.Dispose();
                }
                brush.Dispose();
            }
            else
            {
                Pen pen = new Pen(color, 3);
                g.DrawEllipse(pen, rectangle);
                pen.Dispose();
            }
        }

       
    }
}
