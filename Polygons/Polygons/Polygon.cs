using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    class Polygon
    {
        List<Point> points { get; set; }
        public Point firstPoint { get; set; }
        public bool finishedDrawing { get; set; }
        Color color { get; set; }

        public Polygon(Color color)
        {
            points = new List<Point>();
            this.color =color;
        }

        public void addPoint(Point newPoint)
        {
            if (points.Count == 0)
                firstPoint = newPoint;

            points.Add(newPoint);
        }

        public bool endCondition(Point movePoint)
        {
            int distance = (int)Math.Sqrt(Math.Pow(movePoint.X - firstPoint.X, 2) + Math.Pow(movePoint.Y
                - firstPoint.Y, 2));
            if (distance <= 5)
            {
                return true;
            }
            return false;
        }

        public int polygonPointCount() { return points.Count; }

        public void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(color);
           
            Point[] pointArray = new Point[points.Count];
            int i = 0;
            foreach(Point point in points)
            {
                pointArray[i] = points.ElementAt(i);
                i++;
            }

            if (finishedDrawing)
            {
                graphics.FillPolygon(brush, pointArray);
            }

            else
            {
                Pen pen = new Pen(color, 3);
                for (int j = 0; j < pointArray.Length - 1; j++)
                {
                    graphics.DrawLine(pen, pointArray[j], pointArray[j + 1]);
                }
                pen.Dispose();
            }
            brush.Dispose();
        }

        public Point getLastPoint()
        {
            return points.ElementAt(points.Count - 1);
        }
    }
}
