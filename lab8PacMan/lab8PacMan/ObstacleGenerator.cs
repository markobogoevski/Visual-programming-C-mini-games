using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8PacMan
{
    public class ObstacleGenerator
    {
        public List<Obstacle> obstacleList { get; set; }
        public Random generator { get; set; }
        public ObstacleGenerator()
        {
            generator = new Random();
            obstacleList = new List<Obstacle>();
        }

        public void addObstacles(Size windowSize,int numberOfObstacles)
        {
            int k = 0;
            while(k!=numberOfObstacles)
            {

                int row = generator.Next((int)Math.Floor((double)windowSize.Height / Food.representation.Height)-2);
                int col = generator.Next((int)Math.Floor((double)windowSize.Width / Food.representation.Width));

                
                Obstacle newObstacle = new Obstacle(col * Food.representation.Width, row * Food.representation.Width);
                if (valid(newObstacle)){
                    k++;
                    obstacleList.Add(newObstacle);
                }
            }
        }

        private bool valid(Obstacle newObstacle)
        {
            if (newObstacle.X == 0 && newObstacle.Y == 0)
                return false;
            if (obstacleList.Count == 0)
                return true;

            foreach(Obstacle obstacle in obstacleList)
            {
                if (newObstacle.intersect(obstacle))
                    return false;   
            }
            return true;
        }
    }
}
