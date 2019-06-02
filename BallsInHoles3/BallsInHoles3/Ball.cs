using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles3
{
    [Serializable]
    class Ball
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }

        public double XVelocity { get; set; }
        public double YVelocity { get; set; }
        public double Angle { get; set; }

        public static int Radius = 25;
        public static double Velocity = 10;

        public Color color { get; set; }

        public Ball(int xCoord, int yCoord, Color color, double Angle)
        {
            XCoord = xCoord;
            YCoord = yCoord;

            this.color = color;
            this.Angle = Angle;

            XVelocity = Velocity * Math.Cos(Angle);
            YVelocity = Velocity * Math.Sin(Angle);
        }

        public void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(brush, rectangle);
            brush.Dispose();
        }

        public void move(Rectangle window)
        {
            XCoord += (int)XVelocity;
            YCoord += (int)YVelocity;
            if (XCoord - Radius <= window.Left)
            {
                XCoord = window.Left + Radius;
                XVelocity = -XVelocity;
            }
            if (XCoord + Radius >= window.Right)
            {
                XCoord = window.Right - Radius;
                XVelocity = -XVelocity;
            }
            if (YCoord - Radius <= window.Top)
            {
                YCoord = window.Top + Radius;
                YVelocity = -YVelocity;
            }
            if (YCoord + Radius >= window.Bottom)
            {
                YCoord = window.Bottom - Radius;
                YVelocity = -YVelocity;
            }
        }
    }
}
