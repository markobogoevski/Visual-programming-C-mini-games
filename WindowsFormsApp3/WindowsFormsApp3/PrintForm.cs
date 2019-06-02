using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PrintForm : Form
    {
        List<PlayedMatch> playedMatches { get; set; }
        public decimal koef { get; set; }
        public decimal uplata { get; set; }
        public decimal danok { get; set; }
        public decimal dobivka { get; set; }
        public PrintForm(decimal koef, decimal uplata, decimal danok,decimal dobivka,List<PlayedMatch>playedMatches)
        {
            this.koef = koef;
            this.uplata = uplata;
            this.danok = danok;
            this.dobivka = dobivka;
            this.playedMatches = playedMatches;
            InitializeComponent();
        }

        public void init()
        {
            lbCoef.Text = koef.ToString();
            lbUplata.Text = uplata.ToString();
            lbDanok.Text = danok.ToString();
            lbDobivka.Text = dobivka.ToString();
            foreach (PlayedMatch played in playedMatches)
            {
                DataGridViewRow row = (DataGridViewRow)dataGrid.Rows[0].Clone();
                row.Cells[0].Value = played.MatchCode;
                row.Cells[1].Value = played.ToString();
                row.Cells[2].Value = played.coef[played.typeOfPlay];
                dataGrid.Rows.Add(row);
            }

        }

        
    }
}
