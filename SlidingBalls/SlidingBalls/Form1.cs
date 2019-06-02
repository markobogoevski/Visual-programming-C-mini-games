using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    public partial class Form1 : Form
    {
        Random random { get; set; }
        BallsDoc balls { get; set; }
        RedBall clickedBall { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            newFile();
        }

        public void newFile()
        {
            clickedBall = null;
            random = new Random();
            balls = new BallsDoc();
        }
   

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int chance = random.Next(2);
                if (chance == 1)
                {
                    GreenBall ball = new GreenBall(e.X, e.Y);
                    balls.addBall(ball);
                }
                else
                {
                    BlueBall ball = new BlueBall(e.X, e.Y);
                    balls.addBall(ball);
                }
                Invalidate(true);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (clickedBall == null)
                {
                    clickedBall = balls.clickRed(e.Location);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                RedBall ball = new RedBall(e.X, e.Y);
                balls.addBall(ball);
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            balls.draw(graphics);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "Active: " + balls.numberOfBalls();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clickedBall != null)
            {
                balls.move(ClientRectangle);
                if (clickedBall.outside == true)
                {
                    balls.removeBall(clickedBall);
                    clickedBall = null;
                }
                Invalidate(true);
            }
        }
    }
}
