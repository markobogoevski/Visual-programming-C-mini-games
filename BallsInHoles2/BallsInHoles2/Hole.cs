using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles2
{
    class Hole
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public static int Radius = 30;
        public Color color { get; set; }
        public int swallowedBalls { get; set; }

        public Hole(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            color = Color.Black;
        }

        public void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rect = new Rectangle(XCoord - Radius, YCoord - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(brush, rect);
            Font font = new Font(FontFamily.GenericSansSerif, 3);
            g.DrawString(swallowedBalls.ToString(), font, brush, new Point(XCoord - 5, YCoord - 2));
            brush.Dispose();
        }

    }
}
