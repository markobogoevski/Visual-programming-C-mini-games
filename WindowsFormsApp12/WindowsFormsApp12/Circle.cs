using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Circle : Shape
    {
        public int Radius { get; set; }
        public int direction { get; set; }
        public static int MAX_RADIUS = 60;
        public static int MIN_RADIUS = 10;
        public Circle(Point location, Color color, int radius) : base(location, color)
        {
            Radius = radius;
            direction = 1;
        }

        public override void bounce()
        {
            if (Radius == MAX_RADIUS)
                direction = -1;
            if (Radius == MIN_RADIUS)
                direction = 1;

            Radius += direction;
        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(Location.X - Radius, Location.Y - Radius, 2 * Radius, 2 * Radius);
            g.FillEllipse(brush, rectangle);
            if (Selected)
            {
                Pen pen = new Pen(Color.Red, 3);
                g.DrawEllipse(pen, rectangle);
                pen.Dispose();
            }
            brush.Dispose();
        }

        public override bool isSelected(Point clickPoint)
        {
            double distance = Math.Sqrt(Math.Pow(clickPoint.X - Location.X, 2) + Math.Pow(clickPoint.Y - Location.Y, 2));
            if (distance <= Radius)
            {
                Selected = true;
                return true;
            }
            else
            {
                Selected = false;
                return false;
            }
        }

    }
}
