using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    public class ListShape
    {
        public List<Shape> shapeList { get; set; }
        public static int RADIUS = 25;
        public Color color { get; set; }
        public ListShape()
        {
            shapeList = new List<Shape>();
        }
        public void clearSelected()
        {
            foreach (Shape shape in shapeList)
                shape.Selected = false;
        }
        public void addShape(Color color,Point location,int type)
        {
            if (type == 1) //Circle
            {
                Circle circle = new Circle(color, location, RADIUS);
                shapeList.Add(circle);

            }else
            {
                Square square = new Square(color, location, RADIUS + 10, RADIUS);
                shapeList.Add(square);
            }
        }

        public void draw(Graphics graphics)
        {
            foreach(Shape shape in shapeList)
            {
                shape.draw(graphics);
            }
        }

        public Shape select(Point clickPoint)
        {
            foreach(Shape shape in shapeList)
            {
                if (shape.select(clickPoint))
                    return shape;
            }
            return null;
        }

        public void bounce()
        {
            foreach(Shape shape in shapeList)
            {
                shape.bounce();
            }
        }

        
    }
}
