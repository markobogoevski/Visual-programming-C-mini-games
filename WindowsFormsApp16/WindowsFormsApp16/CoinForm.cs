using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp16
{
    public partial class CoinForm : Form
    {
        public String fileName;
        Coins coinsDoc;
        bool toSave;
        public CoinForm()
        {
            toSave = true;
            fileName = null;
            coinsDoc = new Coins();
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;
        }

        public CoinForm(Form parent, String fileName = null) : this()
        {
            this.MdiParent = parent;
            if (fileName != null)
            {
                openFile(fileName);
            }
        }

        public void saveFile()
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Saving coin file..";
                saveFileDialog.Filter = "Coin file (*.coi)|*.coi";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                }
            }
            if (fileName != null)
            {
                IFormatter formatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                formatter.Serialize(fileStream, coinsDoc);
                fileStream.Close();
                toSave = false;
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this,e.X,e.Y);
            }
        }

        private void addCoinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            coinsDoc.addCoin();
            toSave = true;
            Invalidate(true);
        }

        private void removeCoinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            coinsDoc.removeCoin();
            toSave = true;
            Invalidate(true);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush br = new SolidBrush(Color.Gold);
            Pen pn = new Pen(Color.Black, 1);
            Graphics canvas = panel1.CreateGraphics();
            canvas.Clear(Color.White);
            for (int nCount = 0; nCount < coinsDoc.NumberOfCoins; nCount++)
            {
                int y = panel1.Size.Height - 50 - 10 * nCount;
                canvas.FillEllipse(br, 40, y, 100, 30);
                canvas.DrawEllipse(pn, 40, y, 100, 30);
                canvas.FillEllipse(br, 40, y - 9, 100, 30);
                canvas.DrawEllipse(pn, 40, y - 9, 100, 30);
            }
            pn.Dispose(); br.Dispose();
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = "#coins : " + coinsDoc.NumberOfCoins;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coinsDoc = new Coins();
            toSave = true;
            Invalidate(true);
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
                   fileName=FileName;
                   IFormatter formatter = new BinaryFormatter();
                   FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                   coinsDoc = (Coins)formatter.Deserialize(fileStream);
                   fileStream.Close();
                   toSave = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile(fileName);
        }

        private void CoinForm_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "SDI Coin";
            if (fileName != null)
            {
                this.Text = this.Text + " - " + Path.GetFileName(fileName);
            }
        }

        private void saveToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
            saveAsToolStripMenuItem.Enabled = toSave;
            saveToolStripButton.Enabled = toSave;
            saveAsToolStripMenuItem.Enabled = toSave;
        }

        private void CoinForm_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
