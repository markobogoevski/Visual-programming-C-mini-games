using lab8PacMan.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8PacMan
{
    public class Food
    {
        public static Image representation = Resources.food;
        public int X { get; set; }
        public int Y { get; set; }
        public bool eaten { get; set; }

        public Food(int x, int y)
        {
            X = x;
            Y = y;
            this.eaten = false;
        }
        public void draw(Graphics graphics)
        {
            graphics.DrawImageUnscaled(representation, X, Y);
        }

    }
}
