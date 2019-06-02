using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles2
{
    public partial class Form1 : Form
    {
        Rectangle windowRectangle { get; set; }
        Color color { get; set; }
        Scene scene { get; set; }
        Random random { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            random = new Random();
            windowRectangle = new Rectangle(30, toolStrip1.Height + menuStrip1.Height + 20,
                ClientSize.Width-2*30,ClientSize.Height - 2 * (toolStrip1.Height + menuStrip1.Height + 20));
            newFile();
        }

        public void newFile()
        {
            color = Color.Red;
            scene = new Scene();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (validClick(e.Location))
            {
                Ball ball = new Ball(e.X, e.Y, color,random.NextDouble()*2*Math.PI);
                scene.addBall(ball);

                if (scene.numberOfBalls() == 1)
                    timer1.Start();

                Invalidate(true);
            }
        }

   

        private bool validClick(Point clickLocation)
        {
            return clickLocation.X-25 >= windowRectangle.Left && clickLocation.X+25 <= windowRectangle.Right
                && clickLocation.Y-25 >= windowRectangle.Top && clickLocation.Y+25 <= windowRectangle.Bottom;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), windowRectangle);
            scene.draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.move(windowRectangle);
            Invalidate();
        }
    }
}
