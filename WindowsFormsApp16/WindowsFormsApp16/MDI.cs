using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp16
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoneyForm moneyForm = new MoneyForm();
            moneyForm.MdiParent = this;
            moneyForm.Show();
        }

        private void newCoinFOrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoinForm coinForm = new CoinForm();
            coinForm.MdiParent = this;
            coinForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Opening coin or money file...";
            openFileDialog.Filter = "Coin file(*.coi)|*.coi|Money file(*.mon)|*.mon";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".coi")
                {
                    CoinForm coinForm = new CoinForm(this, openFileDialog.FileName);
                    if (coinForm.fileName != null)
                        coinForm.Show();
                    else
                        coinForm.Dispose();
                }
                else if(Path.GetExtension(openFileDialog.FileName)==".mon")
                {
                    MoneyForm moneyForm = new MoneyForm(this, openFileDialog.FileName);
                    if (moneyForm.fileName != null)
                        moneyForm.Show();
                    else
                        moneyForm.Dispose();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm is MoneyForm)
                ((MoneyForm)activeForm).saveFile();
            else if (activeForm is CoinForm)
                ((CoinForm)activeForm).saveFile();
        }
    }
}
