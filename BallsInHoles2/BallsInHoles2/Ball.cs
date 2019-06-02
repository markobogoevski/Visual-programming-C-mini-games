using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles2
{
    class Ball
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public static int Radius = 25;
        public Color color { get; set; }
        public double Velocity { get; set; }
        public float XVelocity { get; set; }
        public float YVelocity { get; set; }
        public double Angle { get; set; }

        public Ball(int xCoord, int yCoord, Color color,double Angle)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            this.color = color;
            Velocity = 10;
            this.Angle = Angle;
            XVelocity = (float)(Math.Cos(this.Angle)*Velocity);
            YVelocity = (float)(Math.Sin(this.Angle)*Velocity);
           
        }

        public void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rect = new Rectangle(XCoord - Radius, YCoord - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(brush, rect);
            brush.Dispose();
        }

        public void move(Rectangle windowRectangle)
        {
            XCoord += (int)XVelocity;
            YCoord += (int)YVelocity;
            if (XCoord-Radius <= windowRectangle.Left)
            {
                XCoord= windowRectangle.Left+Radius;
                XVelocity=-XVelocity;

            }
            if (XCoord+Radius >= windowRectangle.Right)
            {
                XCoord = windowRectangle.Right - Radius;
                XVelocity = -XVelocity;

            }
            if (YCoord-Radius <= windowRectangle.Top)
            {
                YCoord = windowRectangle.Top + Radius;
                YVelocity = -YVelocity;

            }
            if (YCoord+Radius >= windowRectangle.Bottom)
            {
                YCoord = windowRectangle.Bottom - Radius;
                YVelocity = -YVelocity;

            }
        }
    }
}
