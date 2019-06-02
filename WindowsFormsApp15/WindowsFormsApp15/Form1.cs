using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp15
{
 
    public partial class Form1 : Form
    {
        String fileName { get; set; }
        Coins coinsDoc;
        Boolean toSave { get; set; }
        public Form1()
        {
            InitializeComponent();
            toSave = true;
            fileName = null;
            this.coinsDoc = new Coins(1);
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.Gold);
            Pen pen = new Pen(Color.Black, 2);

            for(int i = 0; i < coinsDoc.CoinsNumber; i++)
            {
                graphics.DrawEllipse(pen, 50, panel1.Height - 50 - i * 20, 100, 30);
                graphics.FillEllipse(brush, 50, panel1.Height - 50 - i * 20, 100, 30);
                graphics.DrawEllipse(pen, 50, panel1.Height - 60 - i * 20, 100, 30);
                graphics.FillEllipse(brush, 50, panel1.Height - 60 - i * 20, 100, 30);
            }
            pen.Dispose();
            brush.Dispose();
        }

        private void addCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.addCoin();
            toSave = true;
            Invalidate(true);
        }

        private void removeCoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc.removeCoin();
            toSave = true;
            Invalidate(true);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "#coins : " + coinsDoc.CoinsNumber.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc = new Coins();
            toSave = true;
            Invalidate(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Saving file..";
                saveFileDialog.Filter = "Coins file |*.coi";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
            }

            if (fileName != null)
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                formatter.Serialize(fileStream, coinsDoc);
                fileStream.Close();
                toSave = false;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveToolStripMenuItem_Click(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Opening file";
            openFileDialog.Filter = "Coins file |*.coi";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Open);
                coinsDoc=(Coins)formatter.Deserialize(fileStream);
                fileStream.Close();
                toSave = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Coins SDI";
            if (fileName != null)
            {
                this.Text = this.Text + " - " + Path.GetFileName(fileName);
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                contextMenuStrip1.Show(this,e.X,e.Y);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
                addCoinToolStripMenuItem_Click(sender, null);
            if (e.KeyChar == '-')
                removeCoinToolStripMenuItem_Click(sender, null);
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveAsToolStripMenuItem.Enabled = toSave;
            saveToolStripButton.Enabled = toSave;
        }
    }
}
