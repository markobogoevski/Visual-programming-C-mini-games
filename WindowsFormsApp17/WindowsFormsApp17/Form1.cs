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

namespace WindowsFormsApp17
{


    public partial class Form1 : Form
    {
        class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel() : base()
            {
                DoubleBuffered = true;
            }
        }

        String fileName;
        bool toSave;
        CircleDoc circles;
        Circle currentCircle;
        bool onFirstClick;
        bool onSecondClick;
        public Form1()
        {
            InitializeComponent();
            newFile();
        }

        public void openFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Opening circles...";
            openFileDialog.Filter = "Circle file(*.cir)|*.cir";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                circles=(CircleDoc)formatter.Deserialize(fileStream);
                fileStream.Close();
            }
        }

        public void saveFile()
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Saving circles...";
                saveFileDialog.Filter = "Circle file(*.cir)|*.cir";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
            }
            if (fileName != null)
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                formatter.Serialize(fileStream, circles);
                fileStream.Close();
            }
        }
        public void newFile()
        {
            circles = new CircleDoc(Color.Green);
            fileName = null;
            toSave = true;
            currentCircle = null;
            onFirstClick = true;
        }

        public void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point clickLocation = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                if (onFirstClick)
                {
                    Circle newCircle = new Circle(clickLocation.X, clickLocation.Y, circles.currentColor);
                    currentCircle = newCircle;
                    circles.addCircle(currentCircle);
                    onFirstClick = false;
                    onSecondClick = true;
                }
                else if (onSecondClick)
                {
                    if (currentCircle != null)
                    {
                        currentCircle.secondClicked = true;
                        Invalidate(true);
                        onFirstClick = true;
                        onSecondClick = false;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                circles.selectCircle(clickLocation);
                panel1.Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                circles.setColor(colorDialog.Color);
            }
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "Circles: " + circles.circleNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Color circles";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        { 
            Graphics graphics = e.Graphics;
            circles.draw(graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (onSecondClick)
                {
                    circles.removeCircle(currentCircle);
                    currentCircle = null;
                    onSecondClick = false;
                    onFirstClick = true;
                    Invalidate(true);
                }
            }
            else if (e.KeyCode == Keys.Up||e.KeyCode==Keys.Right||e.KeyCode==Keys.Left||e.KeyCode==Keys.Down)
            {
                circles.move(e.KeyCode);
                Invalidate(true);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mouseLocation = e.Location;
            if (onSecondClick)
            {
                double distance = Math.Sqrt(Math.Pow(mouseLocation.X - currentCircle.XCoord, 2) + Math.Pow(mouseLocation.Y - currentCircle.YCoord, 2));
                currentCircle.setRadius((int)distance);
                panel1.Invalidate();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circles = new CircleDoc(Color.Green);
            currentCircle = null;
            onFirstClick = true;
            toSave = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveFile();
        }
    }
}
