using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles3
{
    [Serializable]
    class Hole
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public static int Radius = 30;
        public static Color color = Color.Black;
        public int numberOfSwallowedBalls { get; set; }

        Font font { get; set; }

        public Hole(int xCoord, int yCoord)
        {
            XCoord = xCoord;
            YCoord = yCoord;
            font = new Font(FontFamily.GenericSansSerif, 15);
        }

        public void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(Hole.color);
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            graphics.FillEllipse(brush, rectangle);
            graphics.DrawString(numberOfSwallowedBalls.ToString(),
                font, new SolidBrush(Color.White),new Point(XCoord-10,YCoord-10));
            brush.Dispose();
        }


    }
}
