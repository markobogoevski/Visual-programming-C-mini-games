using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnConfirm.Enabled)
                btnConfirm.Enabled = true;
            else
                btnConfirm.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            String songName = tbName.Text;
            int songDuration = (int)numDuration.Value;
            double songRating = double.Parse(tbRating.Text);
            Song song = new Song(songName, songDuration, songRating);
            lbSongs.Items.Add(song);

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            lbSongs.Items.RemoveAt(lbSongs.SelectedIndex);
            button1.Enabled = false;
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
