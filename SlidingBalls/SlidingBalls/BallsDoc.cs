using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    class BallsDoc
    {
        List<Ball> balls { get; set; }

        public BallsDoc()
        {
            balls = new List<Ball>();
        }

        public void addBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void removeBall(Ball ball)
        {
            balls.Remove(ball);
        }

        public int numberOfBalls() { return balls.Count; }

        public void draw(Graphics graphics)
        {
            foreach(Ball ball in balls)
            {
                ball.draw(graphics);
            }
        }

        public RedBall clickRed(Point clickPoint)
        {
            foreach (Ball ball in balls)
            {
                if (ball is RedBall)
                {
                    RedBall redBall = (RedBall)ball;
                    int distance = (int) Math.Sqrt(Math.Pow(redBall.XCoord - clickPoint.X, 2) +
                        Math.Pow(redBall.YCoord - clickPoint.Y, 2));
                    if (distance <= Ball.Radius)
                    {
                        redBall.clicked = true;
                        return redBall;
                    }
                }
            }
            return null;
        }

        public void move(Rectangle windowSize)
        {
            for(int i = balls.Count - 1; i >= 0; i--)
            {
                if (i >= 0)
                {
                    Ball ball = balls.ElementAt(i);
                    if (ball!=null&&ball is RedBall)
                    {
                        RedBall redBall = (RedBall)ball;
                        if (redBall.clicked)
                        {
                            redBall.move(windowSize);
                            GreenBall green = intersectWithGreenBall(redBall);
                            if (green != null)
                                balls.Remove(green);
                        }
                    }
                }
            }
        }

        public GreenBall intersectWithGreenBall(RedBall redBall)
        {
            foreach(Ball ball in balls)
            {
                if (ball is GreenBall)
                {
                    GreenBall green = (GreenBall)ball;
                    if( redBall.intersectsWithGreenBall(green))
                    return green;
                }
            }
            return null;
        }

        public void disselect()
        {
            foreach (Ball ball in balls)
            {
                if (ball is RedBall)
                {
                    RedBall redBall = (RedBall)ball;
                    redBall.clicked = false;
                }
            }
        }
    }
}
