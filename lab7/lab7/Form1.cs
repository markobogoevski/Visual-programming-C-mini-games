using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        RandomBallGenerator generator { get; set; }
        List<Ball> balls { get; set; }
        public Form1()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            generator = new RandomBallGenerator();
            balls = new List<Ball>();
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void addNewBall()
        {
            while (true)
            {
                Ball newBall = generator.getNewBall(this.Size);
                int flag = 1;
                foreach(Ball ball in balls)
                {
                    if (ball.intersects(newBall))
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 0)
                    continue;

                balls.Add(newBall);
                break;
            }
            Invalidate();
        }

        public void moveAll()
        {
            foreach(Ball ball in balls)
            {
                ball.move();
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            foreach (Ball ball in balls)
            {
                ball.draw(graphics);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addNewBall();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(balls.Count!=0)
            {
                moveAll();
            }
        }
    }
}
