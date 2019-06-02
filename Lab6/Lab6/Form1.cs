using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Equation currentEquation { get; set; }
        NumberGenerator equationGenerator { get; set; }
        Player currentPlayer;
        List<Player> allPlayers;
        public Form1()
        {
            allPlayers = new List<Player>();
            InitializeComponent();
            equationGenerator = new NumberGenerator();
            pbTime.Value = pbTime.Maximum;
        }

        public void newGame()
        {

            if(tbName.Text.Length==0)
            {
                MessageBox.Show("You must enter the name!");
                return;
            }

            string name = tbName.Text;
            currentPlayer = new Player(name);
            startGame();
        }

        public void startGame()
        {
            btnNewGame.Enabled = false;
            currentEquation = equationGenerator.getNewEquation();
            tbFirstOperand.Text = currentEquation.FirstOperand.ToString();
            tbSecondOperand.Text = currentEquation.SecondOperand.ToString();
            tbOperator.Text = currentEquation.Operator.ToString();
            timeCount.Start();
        }

        public void guessResult()
        {
            int guess;
            if (int.TryParse(tbResult.Text, out guess)&&currentPlayer!=null)
            {
                if (currentPlayer.guessEquation(currentEquation, guess))
                {
                    pbPoints.Value = currentPlayer.Points;
                    lblPoints.Text = currentPlayer.Points.ToString();
                    tbResult.Clear();
                    currentEquation = equationGenerator.getNewEquation();
                    tbFirstOperand.Text = currentEquation.FirstOperand.ToString();
                    tbSecondOperand.Text = currentEquation.SecondOperand.ToString();
                    tbOperator.Text = currentEquation.Operator.ToString();
                }
            }
        }

        public void resetGame()
        {
            timeCount.Stop();
            if (currentPlayer != null)
                MessageBox.Show("Game restarted. Points : " + currentPlayer.Points);
            tbName.Clear();
            tbFirstOperand.Clear();
            tbOperator.Clear();
            tbSecondOperand.Clear();
            tbResult.Clear();
            pbTime.Value = pbTime.Maximum ;
            pbPoints.Value = 0;
            lblPoints.Text = "0";
            lblTime.Text = "00:00";
            if(currentPlayer!=null)
            allPlayers.Add(currentPlayer);
            btnNewGame.Enabled = true;
            currentPlayer = null;
        }

        public void bestPlayers()
        {
            if (allPlayers.Count != 0)
            {
                allPlayers.Sort();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (Player player in allPlayers)
                {
                    stringBuilder.Append(player);
                }
                MessageBox.Show(stringBuilder.ToString());
            }
        }

        private void timeCount_Tick(object sender, EventArgs e)
        {
            currentPlayer.TimeInSeconds--;
            int playerTime = currentPlayer.TimeInSeconds;
            int minutes = playerTime / 60;
            int seconds = playerTime % 60;
            lblTime.Text = String.Format("{0:00}:{1:00}", minutes, seconds);
            pbTime.Value = playerTime;
            if (pbTime.Value == 0)
            {
                resetGame();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnBestPlayers_Click(object sender, EventArgs e)
        {
            bestPlayers();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guessResult();
        }
    }
}
