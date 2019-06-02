using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp16
{
    public partial class MoneyForm : Form
    {
        public String fileName;
        Money moneyDoc;
        bool toSave;
        public MoneyForm()
        {
            fileName = null;
            moneyDoc = new Money();
            toSave = true;
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
        }

        public MoneyForm(Form parent,String fileName):this()
        {
            this.MdiParent = parent;
            if (fileName != null)
            {
                openFile(fileName);
            }
        }

        private void addMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyDoc.addMoneyBank();
            toSave = true;
            Invalidate(true);
        }

        private void removeMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyDoc.removeMoneyBank();
            toSave = true;
            Invalidate(true);
        }

        private void MoneyForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this,e.X,e.Y);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moneyDoc = new Money();
            Invalidate(true);
            toSave = true;
        }

        public void saveFile()
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Saving money file..";
                saveFileDialog.Filter = "Money file (*.mon)|*.mon";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
            }
            if (fileName != null)
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                formatter.Serialize(fileStream, moneyDoc);
                fileStream.Close();
                toSave = false;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveToolStripMenuItem_Click(sender, e);
        }

        public void openFile(String FileName)
        {
                    fileName = FileName;
                    IFormatter formatter = new BinaryFormatter();
                    FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                    moneyDoc = (Money)formatter.Deserialize(fileStream);
                    fileStream.Close();
                    toSave = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile(fileName);
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveToolStripMenuItem.Enabled = toSave;
            saveToolStripButton.Enabled = toSave;
            saveAsToolStripMenuItem.Enabled = toSave;
        }

        private void MoneyForm_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "SDI Money";
            if (fileName != null)
            {
                this.Text = this.Text + " - " + Path.GetFileName(fileName);
            }

            Graphics graphics = e.Graphics;
            Brush brush = new SolidBrush(Color.LightGreen);
            Pen pen = new Pen(Color.Black, 2);
            graphics.Clear(Color.White);

            for(int i = 0; i < moneyDoc.NumberOfMoneyBanks; i++)
            {
                graphics.DrawRectangle(pen, 20 + i * 20+toolStrip2.Width, 15 + i * 10+toolStrip1.Height+menuStrip2.Height, 200, 80);
                graphics.FillRectangle(brush, 20 + i * 20 + toolStrip2.Width, 15 + i * 10 + toolStrip1.Height + menuStrip2.Height, 200, 80);
                graphics.DrawEllipse(pen, 20 + i * 20 + toolStrip2.Width+75, 15 + i * 10 + toolStrip1.Height + menuStrip2.Height+5, 40, 70);
            }
            brush.Dispose();
            pen.Dispose();
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "#money : " + moneyDoc.NumberOfMoneyBanks;
        }
    }
}
