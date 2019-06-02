using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8PacMan
{
    public class Obstacle
    {
        public int X { get; set; }
        public int Y { get; set; }
        static int Width = Food.representation.Width;
        static int Height = Food.representation.Height*3;
        public Rectangle rectangle { get; set; }

        public Obstacle(int x, int y)
        {
            X = x;
            Y = y;
            rectangle = new Rectangle(X, Y, Obstacle.Width, Obstacle.Height);
        }

        public void draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.MediumPurple, 3);
          //  Brush brush = new SolidBrush(Color.DarkSlateGray);

            Rectangle rectangle = new Rectangle(X, Y, Width, Height);
            graphics.DrawRectangle(pen, rectangle);
            //graphics.FillRectangle(brush, rectangle);
            pen.Dispose();
            //brush.Dispose();
        }

        public bool intersect(Obstacle otherObstacle)
        {
            Rectangle newRectangle = new Rectangle(X-1, Y-1, Width + 2, Height + 2);
            return newRectangle.IntersectsWith(otherObstacle.rectangle);
        }
    }
}
