using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8PacMan
{
    public class Pacman
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        bool mouthOpen { get; set; }
        int direction { get; set; }
        int turn { get; set; }
        Random random;

        public Pacman(int X,int Y,int radius)
        {
            turn = 1;
            this.X = X;
            this.Y = Y;
            random = new Random();
            Radius = radius;
            this.mouthOpen = false;
            this.direction = 30;
        }

        public void move(Keys key,Size windowSize,List<Obstacle>obstacleList)
        {
            int temp;
            switch (key)
            {
                case Keys.W:
                    Y -= direction;
                    if (Y - Radius < 0)
                    {
                        temp = Y + direction;
                        Y = windowSize.Height - Radius;
                        if (hitObstacle(obstacleList))
                            Y = temp;
                    }
                    if (hitObstacle(obstacleList)) 
                        Y +=direction;
                    turn = 4;
                    break;
                case Keys.D:
                    X += direction;
                    if (X + Radius > windowSize.Width)
                    {
                        temp = X - direction;
                        X = Radius;
                        if (hitObstacle(obstacleList))
                            X = temp;
                    }
                    if (hitObstacle(obstacleList))
                        X -= direction;
                    turn = 1;
                    break;
                case Keys.S:
                    Y += direction;
                    if (Y + Radius > windowSize.Height)
                    {
                        temp = Y - direction;
                        Y = Radius;
                        if (hitObstacle(obstacleList))
                            Y = temp;
                    }
                    if (hitObstacle(obstacleList))
                        Y -= direction;
                    turn = 2;
                    break;
                case Keys.A:
                    X -= direction;
                    if (X - Radius < 0)
                    {
                        temp = X + direction;
                        X = windowSize.Width-Radius;
                        if (hitObstacle(obstacleList))
                            X = temp;
                    }
                    if (hitObstacle(obstacleList))
                        X += direction; 
                    turn = 3;
                    break;
            }
            toggleMouth();
        }

        private bool hitObstacle(List<Obstacle> obstacleList)
        {
            foreach(Obstacle obstacle in obstacleList)
            {
                Rectangle obstacleRectangle = obstacle.rectangle;
                Rectangle pacmanRectangle = new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2);
                if (obstacleRectangle.IntersectsWith(pacmanRectangle))
                    return true;
            }
            return false;
        }

        public void toggleMouth()
        {
            if (mouthOpen)
                mouthOpen = false;
            else
                mouthOpen = true;
        }

        public bool eatFood(Food food)
        {
            if (food.eaten == true)
            {
                return false;
            }
            else
            {
                food.eaten = true;
                return true;
            }
        }

        public void draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(Color.Red);
            if (mouthOpen)
            {
                if(turn==1)
                    graphics.FillPie(brush, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2),
                        45, 270);
                else if(turn==2)
                    graphics.FillPie(brush, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2),
                                        135, 270);
                else if (turn == 3)
                    graphics.FillPie(brush, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2),
                                        225, 270);
                else
                    graphics.FillPie(brush, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2),
                                        315, 270);
            }
            else
            {
                graphics.FillEllipse(brush, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2));
            }

            brush.Dispose();
        }
    }
}
