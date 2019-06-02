using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{
    public abstract class Ball
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public static int Radius = 30;
        public Color color { get; set; }

        protected Ball(int xCoord, int yCoord,Color color)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            this.color = color;
        }

        public void draw(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, 2 * Radius, 2 * Radius);
            Brush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, rectangle);
            brush.Dispose();
        }
    }
}
