using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        BallList listOfBalls { get; set; }
        HoleGenerator holeGenerator { get; set; }
        List<Hole> holes { get; set; }
        Color color { get; set; }
        public Form1()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            InitializeComponent();
            color = Color.Red;
            listOfBalls = new BallList();
            holeGenerator = new HoleGenerator();
            holes = new List<Hole>();
            holes = holeGenerator.getNewHoles(mainScreen);
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            listOfBalls.move(holes);
            toolStripLabel.Text = "# Balls : " + listOfBalls.size().ToString();
            mainScreen.Invalidate();
        }

        private void mainScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            listOfBalls.draw(graphics);
            
            foreach (Hole hole in holes)
            {
                hole.draw(graphics);
            }
            
        }

        private void mainScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point clickPoint = e.Location;
                if (clickPoint.X - 25 >= 0 && clickPoint.X + 25 <= mainScreen.Width
                    && clickPoint.Y - 25 >= 0 && clickPoint.Y + 25 <= mainScreen.Height)
                {
                    int randomAngle = HoleGenerator.getRandomAngle(-1);
                    Ball newBall = new Ball(clickPoint.X, clickPoint.Y, 25, color, mainScreen.ClientRectangle, randomAngle);
                    listOfBalls.addBall(newBall);
                    toolStripLabel.Text = "# Balls : " + listOfBalls.size().ToString();
                    mainScreen.Invalidate();
                }
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            holeGenerator = new HoleGenerator();
            holes = holeGenerator.getNewHoles(mainScreen);
            mainScreen.Invalidate();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                color = dialog.Color;
                mainScreen.Invalidate();
            }
        }
    }
}
