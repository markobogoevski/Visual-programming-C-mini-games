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
    public partial class Form1 : Form
    {
        public List<Team> listOfTeams;
        public List<Match> listOfMatches;
        public List<PlayedMatch> listOfPlayedMatches;
        public Form1()
        {
            listOfTeams = new List<Team>();
            listOfMatches = new List<Match>();
            listOfPlayedMatches = new List<PlayedMatch>();
            InitializeComponent();
        }

        private void updateDobivka()
        {
            decimal coef;
            decimal.TryParse(tbCoef.Text, out coef);

            int pay = (int)nudVlog.Value;

            decimal dobivka = coef * pay-pay-(18/100)*(coef*pay-pay);
            tbDobivka.Text = dobivka.ToString();
        }
        private decimal totalCoefficient()
        {
            decimal totalCoef = 0;
            foreach(PlayedMatch played in lbTicket.Items)
                totalCoef += played.coef[played.typeOfPlay];

            tbCoef.Text = totalCoef.ToString();
            return totalCoef;
        }
        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                lbTeams.Items.Add(dialog.team);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTeams.Items.RemoveAt(lbTeams.SelectedIndex);
            button1.Enabled = false;
        }

        private void lbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbTeams.SelectedIndex!=-1)
            button1.Enabled = true;
        }

        private void btnAddInBilten_Click(object sender, EventArgs e)
        {
            if (lbTeams.SelectedItems.Count == 2)
            {
                Team team1 = (Team)lbTeams.SelectedItems[0];
                Team team2 = (Team)lbTeams.SelectedItems[1];
                if (String.Equals(team1.Country, team2.Country, StringComparison.Ordinal))
                {
                    if (tbCode.Text.Length != 0 && noLetter(tbCode.Text))
                    {
                        string code = tbCode.Text;
                        if (codeValid(code))
                        {
                            decimal[] decimals = new decimal[3];

                            decimals[0] = numericUpDown1.Value;
                            decimals[1] = numericUpDown2.Value;
                            decimals[2] = numericUpDown3.Value;
                            Match match = new Match(code, team1, team2,decimals);
                            lbBilten.Items.Add(match);
                            tbCode.Clear();
                        }
                        else
                            MessageBox.Show("You mustn't enter a match with code equal to some other already entered match!");
                    }
                    else
                        MessageBox.Show("You must first enter the code for the match! (Code must be all numbers!)");
                }
                else
                    MessageBox.Show("Teams must be from the same country!");
            }
            else
                MessageBox.Show("You must enter exactly 2 teams!");
        }

        private bool codeValid(string code)
        {
            foreach (Match match in lbBilten.Items)
                if (match.MatchCode.Equals(code, StringComparison.Ordinal))
                    return false;
            return true;
        }

        private bool noLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if (!char.IsDigit(text[i]))
                    return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbBilten.Items.RemoveAt(lbBilten.SelectedIndex);
            button2.Enabled = false;
        }

        private void lbBilten_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (lbBilten.SelectedIndex != -1)
            {
                Match match = (Match)lbBilten.SelectedItem;
                addPlayedMatch(match);
            }
            else
            {
                if(tbCodeBilten.Text.Length!=0)
                {
                    string code = tbCodeBilten.Text;
                    foreach (Match match in lbBilten.Items)
                        if (code.Equals(match.MatchCode, StringComparison.Ordinal))
                        {
                            addPlayedMatch(match);
                            return;
                        }

                    MessageBox.Show("No such match code!");

                }
                else
                MessageBox.Show("Select one match or enter match code!");
            }
                
        }

        private void addPlayedMatch(Match match1)
        {
            string type;
            if (cbBiltenType.SelectedItem == null) {
                MessageBox.Show("You must specify the type first!");
                    return; }
            type = (string)cbBiltenType.SelectedItem;
            int number;
            if (type.Equals("1"))
                number = 0;
            else if (type.Equals("X"))
                number = 1;
            else
                number = 2;

            PlayedMatch playedMatch = new PlayedMatch(match1.MatchCode, match1.homeTeam, match1.awayTeam, match1.coef, number);
            if (lbTicket.Items.Contains(playedMatch))
            {
                MessageBox.Show("Already contains this match!");
                return;
            }

            lbTicket.Items.Add(playedMatch);
            totalCoefficient();
        }

        private void update(object sender, EventArgs e)
        {
            updateDobivka();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            decimal coef;
            decimal.TryParse(tbCoef.Text, out coef);

            decimal dobivka;
            decimal.TryParse(tbDobivka.Text, out dobivka);

            decimal vlog;
            decimal.TryParse(nudVlog.Text, out vlog);
            List<PlayedMatch> playedMatches = new List<PlayedMatch>();
            foreach (PlayedMatch played in lbTicket.Items)
                playedMatches.Add(played);

            PrintForm printForm = new PrintForm(coef, vlog, 0M, dobivka,playedMatches);
            printForm.init();

            printForm.ShowDialog();
        }
    }
}
