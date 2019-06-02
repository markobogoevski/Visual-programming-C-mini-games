using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    class Hole : PlainBall
    {
        public int swallowedHoles { get; set; }

        public Hole(int xCoord, int yCoord,int Radius,Color color):base(xCoord,yCoord, Radius, color)
        {
            swallowedHoles = 0;
        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Brush brushS = new SolidBrush(Color.White);
            Rectangle rectangle = new Rectangle(XCoord - Radius, YCoord - Radius, Radius * 2, Radius * 2);
            g.FillEllipse(brush, rectangle);
            Font font = new Font(FontFamily.GenericSansSerif, 10);
            g.DrawString(swallowedHoles.ToString(),font, brushS, new PointF(XCoord-10, YCoord-10));
            brush.Dispose();
        }
    }
}
