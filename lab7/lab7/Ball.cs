using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Ball
    {
        int X { get; set; }
        int Y { get; set; }
        public Rectangle boundRectangle { get; set; }
        int angle { get; set; }
        int velocity { get; set; }
        int radius { get; set; }
        int velocityX { get; set; }
        int velocityY { get; set; }

        public Ball(int X,int Y,Rectangle boundRectangle, int angle, int velocity, int radius)
        {
            this.X = X;
            this.Y = Y;
            this.boundRectangle = boundRectangle;
            this.angle = angle;
            this.velocity = velocity;
            this.radius = radius;
            velocityX = (int)(velocity * Math.Cos(angle));
            velocityY = -(int)(velocity * Math.Sin(angle));
        }

        public void move()
        {
                X += velocityX;
                if (X + radius >= boundRectangle.Right || X - radius <= boundRectangle.Left)
                {
                    velocityX = -velocityX;
                    X += velocityX;
                }
                Y += velocityY;
                if (Y-radius <= boundRectangle.Top || Y+radius >= boundRectangle.Bottom)
                {
                    velocityY = -velocityY;
                    Y += velocityY;
                }

        }

        public bool intersects(Ball otherBall)
        {
            return boundRectangle.IntersectsWith(otherBall.boundRectangle);
        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            Brush brush = new SolidBrush(Color.Red);
            g.DrawRectangle(pen, boundRectangle);
            g.FillEllipse(brush, new Rectangle(X-radius,Y-radius,radius*2,radius*2));
            brush.Dispose();
        }
    }
}
