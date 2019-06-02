using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class RandomBallGenerator
    {
        Random randomGenerator { get; set; }
        public RandomBallGenerator()
        {
            randomGenerator = new Random();
        }

        public Ball getNewBall(Size windowSize)
        {
            int Xrectangle = randomGenerator.Next(0, windowSize.Width - 100);
            int Yrectangle = randomGenerator.Next(0, windowSize.Height - 100);
            Rectangle newBoundRectangle = new Rectangle(Xrectangle, Yrectangle, randomGenerator.Next(35, 100), randomGenerator.Next(35, 100));
            int[] angles = { 0, 90, 180, 270};
            int index = randomGenerator.Next(4);
            int angle = angles[index];
            int velocity = randomGenerator.Next(3, 10);
            int radius = randomGenerator.Next(3, 15);
            int X = newBoundRectangle.X + newBoundRectangle.Width / 2;
            int Y = newBoundRectangle.Y + newBoundRectangle.Height / 2;
            return new Ball(X, Y, newBoundRectangle, angle, velocity, radius);
        }
    }
}
