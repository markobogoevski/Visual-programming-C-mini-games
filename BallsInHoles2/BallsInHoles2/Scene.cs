using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles2
{
    class Scene
    {
        List<Ball> balls { get; set; }
        List<Hole> holes { get; set; }
        Random randomGenerator { get; set; }

        public Scene()
        {
            balls = new List<Ball>();
            holes = new List<Hole>();
            randomGenerator = new Random();
            generateHoles();
        }

        public int numberOfBalls()
        {
            return balls.Count;
        }

        private void generateHoles()
        {
            //throw new NotImplementedException();
        }

        public void addHole(Hole hole)
        {
            holes.Add(hole);
        }

        public void addBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void removeBall(Ball ball)
        {
            balls.Remove(ball);
        }

        public void draw(Graphics g)
        {
            foreach(Ball ball in balls)
            {
                ball.draw(g);
            }
            foreach(Hole hole in holes)
            {
                hole.draw(g);
            }
        }

        public void move(Rectangle windowRectangle)
        {
            foreach(Ball ball in balls)
            {
                ball.move(windowRectangle);
            }
        }
    }
}
