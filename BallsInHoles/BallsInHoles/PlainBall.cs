using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    class PlainBall
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Radius { get; set; }
        public Color color { get; set; }

        protected PlainBall(int xCoord, int yCoord, int radius, Color color)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            Radius = radius;
            this.color = color;
        }

        public virtual void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(brush, rectangle);
            brush.Dispose();
        }

        public virtual bool intersectWith(PlainBall otherBall)
        {
            int distance = (int)(Math.Sqrt(Math.Pow(XCoord - otherBall.XCoord, 2) + Math.Pow(YCoord - otherBall.YCoord, 2)));
            if (distance <= Radius + otherBall.Radius)
                return true;
            return false;
        }
    }
}
