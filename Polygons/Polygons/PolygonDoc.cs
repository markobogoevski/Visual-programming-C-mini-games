using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    class PolygonDoc
    {
        List<Polygon> polygons { get; set; }
        public PolygonDoc()
        {
            polygons = new List<Polygon>();
        }

        public void addPolygon(Polygon polygon)
        {
            polygons.Add(polygon);
        }

        public int polygonNumber() { return polygons.Count; }

        public void draw(Graphics g)
        {
            foreach(Polygon polygon in polygons)
            {
                polygon.draw(g);
            }
        }
    }
}
