using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public abstract class Shape
    {
        public bool Selected { get; set; }
        public Color color { get; set; }
        public Point location { get; set; }

        public Shape(Color color, Point location)
        {
            this.color = color;
            this.location = location;
        }

        public abstract void draw(Graphics g);
        public abstract void move(Point otherPoint);
        public abstract bool select(Point clickPoint);
        public abstract void delete();
        public abstract void bounce();
    }
}
