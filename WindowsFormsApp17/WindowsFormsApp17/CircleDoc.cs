using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> circles;
        public Color currentColor;
        public int Velocity { get; set; }
        public CircleDoc(Color currentColor)
        {
            Velocity = 5;
            circles = new List<Circle>();
            this.currentColor = currentColor;
        }

        public void setColor(Color color)
        {
            this.currentColor = color;
        }

        public void draw(Graphics g)
        {
            foreach(Circle circle in circles)
            {
                circle.draw(g);
            }
        }

        public void move(Keys keyCode)
        {
            for(int i=circles.Count-1;i>=0;i--) 
            {
                if (circles.Count - 1 >= i)
                {
                    Circle circle = circles.ElementAt(i);
                    if (circle.selected && circle != null)
                    {
                        {
                            switch (keyCode)
                            {
                                case Keys.Up:
                                    circle.YCoord -= Velocity;
                                    checkIntersect(circle);
                                    break;
                                case Keys.Right:
                                    circle.XCoord += Velocity;
                                    checkIntersect(circle);
                                    break;
                                case Keys.Left:
                                    circle.XCoord -= Velocity;
                                    checkIntersect(circle);
                                    break;
                                case Keys.Down:
                                    circle.YCoord += Velocity;
                                    checkIntersect(circle);
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void checkIntersect(Circle circle)
        {
           for(int i = circles.Count - 1; i >= 0; i--)
            {
                if (circles.ElementAt(i) != circle&&circles.ElementAt(i).color==circle.color)
                {
                    double distance = Math.Sqrt(Math.Pow(circles.ElementAt(i).XCoord - circle.XCoord, 2) + Math.Pow(circles.ElementAt(i).YCoord - circle.YCoord, 2));
                    if (distance <= circles.ElementAt(i).Radius + circle.Radius)
                    {
                        circles.RemoveAt(i);
                        circles.Remove(circle);
                        return;
                    }
                }
            }
        }

        public void addCircle(Circle circle)
        {
            circles.Add(circle);
        }

        public void removeCircle(Circle circle)
        {
            circles.Remove(circle);
        }

        public int circleNumber()
        {
            int count = 0;
            foreach(Circle circle in circles)
            {
                if (circle.secondClicked)
                    count++;
            }

            return count;
        }

        public void selectCircle(Point clickLocation)
        {
            foreach(Circle circle in circles)
            {
           
                double distance = Math.Sqrt(Math.Pow(clickLocation.X - circle.XCoord, 2) + Math.Pow(clickLocation.Y - circle.YCoord, 2));
                if(distance<=circle.Radius)
                {
                    circle.select();
                    return;
                }
            }
        }
    }
}
