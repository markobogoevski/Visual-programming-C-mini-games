using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8PacMan
{
    public class FoodList
    {
        ObstacleGenerator generator { get; set; }
        public Dictionary<Point, Food> foodByPlace { get; set; }
        public FoodList()
        {
            generator = new ObstacleGenerator();
            foodByPlace = new Dictionary<Point,Food>();
        }

        public void fillDictionary(Size windowSize,List<Obstacle>obstacles)
        {
            for (int i = 0; i < Math.Floor((double)windowSize.Height / Food.representation.Height); i++)
            {
                for(int j = 0; j < Math.Floor((double)windowSize.Width / Food.representation.Width); j++)
                {
                    int flag = generator.generator.Next(2);
                    if (flag == 1&&(i!=0||j!=0)&&notInObstacle(j * Food.representation.Width,
                            i * Food.representation.Height,obstacles))
                    {
                        Point newPoint = new Point(j * Food.representation.Width,
                            i * Food.representation.Height);
                        Food newFood = new Food(j * Food.representation.Width,
                            i * Food.representation.Height);

                        foodByPlace.Add(newPoint, newFood);
                    }
                }
            }
        }

        private bool notInObstacle(int x,int y,List<Obstacle> obstacles)
        {
            foreach(Obstacle obstacle in obstacles)
            {
                Rectangle rectangle = obstacle.rectangle;
                if (x >= rectangle.Left && x <= rectangle.Right
                    && y <= rectangle.Bottom && y >= rectangle.Top)
                    return false;
            }
            return true;
        }

        public void draw(Graphics graphics)
        {
            foreach(Food food in foodByPlace.Values)
            {
                if(!food.eaten)
                food.draw(graphics);
            }
        }
    }
}
