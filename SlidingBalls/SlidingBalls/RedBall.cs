using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    class RedBall : Ball
    {
        public int Angle { get; set; }
        public int XVelocity { get; set; }
        public int YVelocity { get; set; }
        public static Random random = new Random();
        public bool outside {get;set;}
        public bool clicked { get; set; }
        public double angle { get; set; }

        public RedBall(int XCoord, int YCoord) : base(XCoord, YCoord, Color.Red)
        {
            XVelocity = 10;
            YVelocity = 10;
            angle = getRandomAngle();
            XVelocity = (int)(XVelocity * Math.Cos(angle));
            YVelocity = -(int)(YVelocity * Math.Sin(angle));
        }

        public void move(Rectangle windowRectangle)
        {
                
                XCoord += XVelocity;
                YCoord += YVelocity;
            if (XCoord + Radius <= windowRectangle.Left ||
                XCoord - Radius >= windowRectangle.Right ||
                YCoord - Radius >= windowRectangle.Bottom ||
                YCoord + Radius <= windowRectangle.Top)
            {
                outside = true;
                clicked = false;
            }
        }

        private double getRandomAngle()
        {
            double[] angles = { 0, Math.PI/2, Math.PI, 3*Math.PI/2 };
            int picker = random.Next(0,4);
            return angles[picker];
        }

        public bool intersectsWithGreenBall(GreenBall blue)
        {
            int distance = (int)Math.Sqrt(Math.Pow(XCoord - blue.XCoord, 2) + Math.Pow(YCoord - blue.YCoord, 2));
            if (distance <= Ball.Radius * 2)
            {
                return true;
            }
            return false;
        }
    }
}
