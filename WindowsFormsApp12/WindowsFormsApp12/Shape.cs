using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    public abstract class Shape
    {
        public Point Location { get; set; }
        public Color color { get; set; }
        public bool Selected { get; set; }

        public Shape(Point location, Color color)
        {
            Location = location;
            this.color = color;
        }

        public abstract void bounce();
        public abstract void draw(Graphics g);
        public virtual void move(Point clickPoint) {
            Location = clickPoint;
        }
        public abstract bool isSelected(Point clickPoint);
    }
}
