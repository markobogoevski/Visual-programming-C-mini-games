using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    public enum shapeType
    {
        CIRCLE,
        SQUARE
    }

    public class ShapeList
    {
       
        public List<Shape> shapes { get; set; }
        public shapeType type { get; set; }
        public static int Radius = 15;

        public ShapeList()
        {
            shapes = new List<Shape>();
            type = shapeType.CIRCLE;
        }

        public void addShape(Point clickLocation,Color color, shapeType type)
        {
            if (type == shapeType.CIRCLE)
            {
                Circle newCircle = new Circle(clickLocation, color, Radius);
                shapes.Add(newCircle);
            }
            else
            {
                Square square = new Square(clickLocation, color, Radius, Radius);
                shapes.Add(square);
            }
        }

        public void draw(Graphics g)
        {
            foreach(Shape shape in shapes)
            {
                shape.draw(g);
            }
        }

        public void bounce()
        {
            foreach(Shape shape in shapes)
                shape.bounce();
        }

        public void clearSelected()
        {
            foreach(Shape shape in shapes)
                shape.Selected = false;
        }

        public Shape selectedShape(Point clickPoint)
        {
            foreach(Shape shape in shapes)
                if (shape.isSelected(clickPoint))
                    return shape;
            
            return null;
        }
    }
}
