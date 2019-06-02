using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    [Serializable]
    class Ball : PlainBall
    {
        int Angle { get; set; }
        int Velocity { get; set; }
        Rectangle Bounds { get; set; }
        public bool visible { get; set; }

        public Ball(int xCoord, int yCoord,int radius, Color color,Rectangle Bounds,int angle):base(xCoord,yCoord,radius,color)
        {
            Angle = angle;
            Velocity = 10;
            this.Bounds = Bounds;
            visible = true;
        }

        public void move(List<Hole> holes)
        {
            int XVelocity = (int)(Velocity * Math.Cos(Angle));
            int YVelocity = (int)(Velocity * Math.Sin(Angle));

            XCoord += XVelocity;
            YCoord += YVelocity;

             if(collisionWithHole(holes))
            {
             visible = false;
            }

            if (XCoord - Radius <= Bounds.Left || XCoord + Radius >= Bounds.Right)
            {
                XCoord -= XVelocity;
                Angle = HoleGenerator.getRandomAngle(Angle);
            }

            if (YCoord - Radius <= Bounds.Top || ( (YCoord + Radius) >= Bounds.Bottom))
            {
                YCoord -= YVelocity;
                Angle = HoleGenerator.getRandomAngle(Angle);
            }
        }

            private bool collisionWithHole(List<Hole> holes)
        {
            foreach(Hole hole in holes)
            {
                if (intersectWith(hole)&&visible)
                {
                    hole.swallowedHoles++;
                    return true;
                }
            }
            return false;
        }

        public override void draw(Graphics g)
        {
            if (visible)
            {
                Brush brush = new SolidBrush(color);
                Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
                g.FillEllipse(brush, rectangle);
                brush.Dispose();
            }
        }
    }
}
