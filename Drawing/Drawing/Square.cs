using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Square : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public static int MAX_WIDTH = 100;
        public static int MIN_WIDHT = 20;
        public static int MIN_HEIGHT = 10;
        public static int MAX_HEIGHT = 100;
        public int dir1 { get; set; }
        public int dir2 { get; set; }

        public Square(Color color,Point location,int width, int height):base(color,location)
        {
            Width = width;
            Height = height;
            dir1 = 1;
            dir2 = 1;
        }

        public override void bounce()
        {
            if (Width == MAX_WIDTH)
                dir1 = -1;
            if (Width == MIN_WIDHT)
                dir1 = 1;
            if (Height == MAX_HEIGHT)
                dir2 = -1;
            if (Height == MIN_HEIGHT)
                dir2 = 1;

            Width += dir1;
            Height += dir2;
        }

        public override void delete()
        {
            this.delete();
        }

        public override void draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            Rectangle rectangle = new Rectangle(location.X - Width / 2, location.Y - Height / 2, Width, Height);
            g.FillRectangle(brush, rectangle);
            if (Selected)
            {
                Pen pen = new Pen(Color.Red, 3);
                g.DrawRectangle(pen, rectangle);
                pen.Dispose();
            }
            brush.Dispose();
        }

        public override void move(Point otherPoint)
        {
            location = otherPoint;
        }

        public override bool select(Point clickPoint)
        {
            Point newClickPoint = new Point(clickPoint.X + Width / 2, clickPoint.Y + Height / 2);
            if (newClickPoint.Y >= location.Y && newClickPoint.Y <= location.Y + Height
                && newClickPoint.X >= location.X && newClickPoint.X <= location.X + Width)
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
