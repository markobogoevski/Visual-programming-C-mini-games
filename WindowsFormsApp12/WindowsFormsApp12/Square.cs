using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    class Square : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int direction1 { get; set; }
        public int direction2 { get; set; }
        public static int MIN_WIDTH = 10;
        public static int MAX_WIDTH = 60;
        public static int MIN_HEIGHT = 10;
        public static int MAX_HEIGHT = 60;

        public Square(Point location,Color color,int height, int width):base(location,color)
        {
            Height = height;
            Width = width;
            direction1 = direction2 = 1;
        }

        public override void bounce()
        {
            if (Width == MAX_WIDTH)
                direction1 = -1;
            if (Width == MIN_WIDTH)
                direction1 = 1;
            if (Height == MAX_HEIGHT)
                direction2 = -1;
            if (Height == MIN_HEIGHT)
                direction2 = 1;

            Width += direction1;
            Height += direction2;
        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(Location.X - Width / 2, Location.Y - Height / 2, Width, Height);
            g.FillRectangle(brush, rectangle);
            if (Selected)
            {
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);
                pen.Dispose();
            }
            brush.Dispose();
        }

        public override bool isSelected(Point clickPoint)
        {
            Point newLocation = new Point(Location.X - Width / 2, Location.Y - Height / 2);
            if (clickPoint.X >= newLocation.X && clickPoint.X <= newLocation.X + Width
                && clickPoint.Y >= newLocation.Y && clickPoint.Y <= newLocation.Y + Height)
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
