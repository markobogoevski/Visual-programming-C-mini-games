using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace BallsInHoles3
{
    public partial class Form1 : Form
    {
        Scene scene { get; set; }
        Color currentColor { get; set; }
        Rectangle windowRectangle { get; set; }
        Random random;
        String pathName { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            windowRectangle = new Rectangle(
                20, menuStrip1.Height + toolStrip1.Height + 10,
                ClientRectangle.Width - 2 * 20, ClientRectangle.Height - 2 * (menuStrip1.Height + toolStrip1.Height + 10));
            newFile();
        }

        public void openFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Opening holes in balls...";
            fileDialog.Filter = "Holes(*.hole)|*.hole";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pathName = fileDialog.FileName;
                IFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(pathName, FileMode.Open, FileAccess.Read, FileShare.None);
                scene=(Scene)formatter.Deserialize(stream);
                stream.Close();
            }
        }

        public void saveFile()
        {
            if (pathName == null)
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                timer1.Stop();
                fileDialog.Title = "Saving holes in balls...";
                fileDialog.Filter = "Holes(*.hole)|*.hole";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathName = fileDialog.FileName;
                    timer1.Start();
                }
            }
            if (pathName != null)
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream stream = new FileStream(pathName,FileMode.Create,FileAccess.ReadWrite,FileShare.None);
                formatter.Serialize(stream, scene);
                stream.Close();
            }
        }

        public void newFile()
        {
            pathName = null;
            random = new Random();
            currentColor = Color.Red;
            scene = new Scene(windowRectangle);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "#Balls : " + scene.ballNumber().ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                double angle = random.NextDouble() * 2 * Math.PI;
                Ball ball = new Ball(e.X, e.Y, currentColor,angle);
                scene.addBall(ball);

                if (scene.ballNumber() == 1)
                    timer1.Start();

                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawRectangle(new Pen(Color.Black,5),windowRectangle);
            scene.draw(graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.move();
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                currentColor = color.Color;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            scene.setNewHoles();
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
            Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pathName = null;
            saveFile();
        }

      
    }
}
