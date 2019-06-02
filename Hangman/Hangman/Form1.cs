using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public WordPicker wordPicker { get; set; }
        public HangmanWord hangman { get; set; }
        public int seconds { get; set; }
        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        public void newGame()
        {
            seconds = 10 * 60;
            wordPicker = new WordPicker();
            String word = wordPicker.pickNextWord();
            hangman = new HangmanWord(word);
            wordGuess.Text = hangman.refreshGuessed();
            triedLetters.Text = hangman.refreshTotalLetters();
            tbGuess.Clear();
            pbTimer.Minimum = 0;
            pbTimer.Maximum = 10 * 60;
            pbTimer.Value = 10 * 60;
            pbWrongCounter.Minimum = 0;
            pbWrongCounter.Maximum = HangmanWord.MAX_GUESSES;
            pbWrongCounter.Value = 0;
            timerTime.Start();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (tbGuess.Text.Length == 1)
            {
                char c = char.ToLower(tbGuess.Text[0]);
                bool hit = hangman.guessLetter(c);
                tbGuess.Clear();
                if (!hit)
                    pbWrongCounter.Value++;
                wordGuess.Text=hangman.refreshGuessed();
                triedLetters.Text=hangman.refreshTotalLetters();
                if (hangman.solvedGame())
                {
                    timerTime.Stop();
                    DialogResult dialogResult = MessageBox.Show("Победивте!Дали сакате нова игра?", "Нова игра?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        newGame();
                    }
                    else
                        this.Close();
                }
                else if (pbWrongCounter.Value == HangmanWord.MAX_GUESSES)
                {
                    timerTime.Stop();
                    DialogResult dialogResult = MessageBox.Show("Изгубивте..Дали сакате нова игра?", "Нова игра?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        newGame();
                    }
                    else
                        this.Close();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            seconds--;
            pbTimer.Value = seconds;
            int minutes = seconds / 60;
            int second = seconds % 60;
            time.Text = String.Format("{0:00}:{1}\n", minutes, second);
            if (seconds == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Изгубивте на време..Дали сакате нова игра?", "Нова игра?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newGame();
                }
                else
                    this.Close();

            }
        }
    }
}
