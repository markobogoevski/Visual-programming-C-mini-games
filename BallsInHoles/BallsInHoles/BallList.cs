using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsInHoles
{
    [Serializable]
    class BallList
    {
        List<Ball> ballList { get; set; }

        public BallList()
        {
            ballList = new List<Ball>();
        }

        public void move(List<Hole>holes)
        {
            for(int i = ballList.Count - 1; i >= 0; i--)
            {
                ballList.ElementAt(i).move(holes);
                if (!ballList.ElementAt(i).visible)
                    ballList.RemoveAt(i);
            }
        }

        public void draw(Graphics g)
        {
            foreach(Ball ball in ballList)
            {
                ball.draw(g);
            }
        }

        public void addBall(Ball newBall)
        {
            ballList.Add(newBall);
        }

        public void removeBall(Ball ballToRemove)
        {
            ballList.Remove(ballToRemove);
        }

        public int size()
        {
            int count = 0;
            foreach(Ball ball in ballList)
            {
                if (ball.visible)
                    count++;
            }
            return count;
        }
    }
}
