using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles3
{
    [Serializable]
    class Scene
    {
        List<Hole> holes { get; set; }
        List<Ball> balls { get; set; }
        public static int numberOfHoles = 5;
        Rectangle window { get; set; }
        Random random;

        public Scene(Rectangle window)
        {
            random = new Random();
            balls = new List<Ball>();
            this.window = window;
            setNewHoles();
        }

        public void setNewHoles()
        {
            holes = generateHoles(window);
        }

        public int ballNumber()
        {
            return balls.Count;
        }

        private List<Hole> generateHoles(Rectangle window)
        {
            int counter = 0;
            List<Hole> holes = new List<Hole>();
            while (counter < Scene.numberOfHoles)
            {
                int XCoord = random.Next(window.Left + Hole.Radius,
                    window.Right - Hole.Radius);
                int YCoord = random.Next(window.Top + Hole.Radius,
                    window.Bottom - Hole.Radius);
                Hole hole = new Hole(XCoord, YCoord);
                if (noCollision(hole, holes))
                {
                    holes.Add(hole);
                    counter++;
                }
            }
            return holes;
        }

        private bool noCollision(Hole hole, List<Hole> holes)
        {
            foreach(Hole altHole in holes)
            {
                int distance =(int) Math.Sqrt(Math.Pow(hole.XCoord - altHole.XCoord, 2) +
                    Math.Pow(hole.YCoord - altHole.YCoord, 2));
                if (distance <= Hole.Radius * 2)
                {
                    return false;
                }
            }
            return true;
        }

        public void addBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void removeBall(Ball ball)
        {
            balls.Remove(ball);
        }

        public void addHole(Hole hole)
        {
            holes.Add(hole);
        }

        public void draw(System.Drawing.Graphics g)
        {
            foreach (Ball ball in balls)
            {
                ball.draw(g);
            }
            foreach (Hole hole in holes)
            {
                hole.draw(g);
            }
        }

        public void move()
        {
            for (int i = balls.Count - 1; i >= 0; i--)
            {
                if (i >= 0)
                {
                    Ball ball = balls.ElementAt(i);
                    ball.move(window);
                    foreach (Hole hole in holes)
                    {
                        int distance = (int)Math.Sqrt(Math.Pow(ball.XCoord - hole.XCoord, 2) +
                            Math.Pow(ball.YCoord - hole.YCoord, 2));
                        if (distance <= Ball.Radius)
                        {
                            balls.Remove(ball);
                            hole.numberOfSwallowedBalls++;
                        }
                    }
                }
            }
        }
    }
}
