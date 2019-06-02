using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    class CircleList
    {
        List<Circle> circles { get; set; }
        public CircleList()
        {
            circles = new List<Circle>();
        }

        public void deleteAll()
        {
            circles.Clear();
        }
        
        public void selectCircle(Point clickPoint)
        {
            foreach(Circle circle in circles)
            {
                if (circle.select(clickPoint))
                    return;
            }
        }

        public int drawn()
        {
            int count = 0;
            foreach(Circle circle in circles)
            {
                if (circle.secondClicked)
                    count++;
            }

            return count;
        }

        public void addCircle(Circle circle)
        {
            circles.Add(circle);
        }

        public void deleteCircle(Circle circle)
        {
            circles.Remove(circle);
        }

        public void draw(Graphics g)
        {
            foreach(Circle circle in circles)
            {
                circle.draw(g);
            }
        }
    }
}
