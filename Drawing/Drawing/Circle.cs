using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public static int MIN_RADIUS = 10;
        public static int MAX_RADIUS = 60;
        public int dir { get; set; }

        public Circle(Color color, Point location,int Radius):base(color, location)
        {
            this.Radius = Radius ;
            dir = 1;
        }

        public override void delete()
        {
            this.delete();
        }

        public override void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(color);
            Size size = new Size(Radius * 2, Radius * 2);
            Rectangle rectangle = new Rectangle(new Point(location.X - Radius, location.Y - Radius), size);
            if (Selected)
            {
                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawEllipse(pen, rectangle);
                pen.Dispose();
            }
            graphics.FillEllipse(brush, rectangle);
            brush.Dispose();
        }

        public override void move(Point otherPoint)
        {
            location = otherPoint;
        }

        public override bool select(Point clickPoint)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(location.X - clickPoint.X, 2) + Math.Pow(location.Y - clickPoint.Y, 2));
            if( distance <= Radius)
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

        public override void bounce()
        {
            
            if (Radius == MAX_RADIUS)
                dir = -1;
            if (Radius == MIN_RADIUS)
                dir = 1;

            Radius += dir;
        }
    }
}
