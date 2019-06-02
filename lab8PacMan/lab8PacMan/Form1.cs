using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8PacMan
{
    public partial class Form1 : Form
    {
        int points;
        int numberOfObstacles;
        int seconds;
        ObstacleGenerator generator;
        FoodList foodL;
        Pacman pacman;
        public Form1()
        {
            numberOfObstacles = 8;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
            pictureBox1.Size = new Size(Food.representation.Width * 20, Food.representation.Height * 13);

            newGame();
        }
      
        public void newGame()
        {
            seconds = 60;
            points = 0;
            generator = new ObstacleGenerator();
            textBox1.Text = points.ToString();
            generator.addObstacles(pictureBox1.Size,numberOfObstacles);
            foodL = new FoodList();
            foodL.fillDictionary(pictureBox1.Size, generator.obstacleList);
            progressBar1.Value = 0;
            progressBar1.Maximum = foodL.foodByPlace.Count;
            pacman = new Pacman(Food.representation.Width / 2, Food.representation.Height / 2, Food.representation.Width / 2);
            pictureBox1.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            pacman.draw(graphics);
            foodL.draw(graphics);
            foreach (Obstacle obstacle in generator.obstacleList)
            {
                obstacle.draw(graphics);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             Keys key = e.KeyCode;
            if (key != Keys.W && key != Keys.D && key != Keys.S && key != Keys.A)
            {
                e.Handled = true;
                return;
            }
            pacman.move(key, pictureBox1.Size, generator.obstacleList);
            int pacmanX = pacman.X;
            int pacmanY = pacman.Y;

            foreach(Food food in foodL.foodByPlace.Values)
            {
                int foodX = food.X + Food.representation.Width / 2;
                int foodY = food.Y + Food.representation.Height / 2;
                int distance = (int)Math.Sqrt(Math.Pow(foodX - pacmanX, 2) + Math.Pow(foodY - pacmanY, 2));
                if (distance + 5 <= (pacman.Radius + Food.representation.Width / 2)) {
                    if (pacman.eatFood(food))
                    {
                        points++;
                        textBox1.Text = points.ToString();
                        progressBar1.Value++;
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            numberOfObstacles+=2;
                            newGame();
                        }
                    }
                }
            }

            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
                newGame();

            seconds--;
            lblTime.Text = String.Format("00:{0,00}", seconds);
        }
    }
}
