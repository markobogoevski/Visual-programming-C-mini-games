using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbWords.Items.Add("лето");
            clbWords.Items.Add("авион");
            clbWords.Items.Add("плажа");
            clbWords.Items.Add("небо");
            clbWords.Items.Add("боја");
            clbWords.Items.Add("сонце");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rtbMessage.Text);
        }

        private void untilStopWord()
        {
            List<string> stopWords = new List<string>();
            foreach(string word in clbWords.SelectedItems)
                stopWords.Add(word);

            getFirstStop(stopWords);
        }

        private void getFirstStop(List<string> stringList)
        {
            string firstWord = stringList.ElementAt(0);
            string message = rtbMessage.Text;
            int index = 0;
            foreach(string word in stringList)
            {
                if (message.IndexOf(word) < message.IndexOf(firstWord))
                {
                    firstWord = word;
                    index = message.IndexOf(word);
                }
            }

            string newMessage = "";
            int i = 0;
            MessageBox.Show(index.ToString());
            foreach(char character in message)
            {
                if (i != index)
                {
                    MessageBox.Show(newMessage);
                    newMessage += character;
                }
                else
                    break;

                i++;
            }
            newMessage += firstWord;
            rtbMessage.Text = newMessage;
        }

        private void clbWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rtbMessage.Text.Length!=0)
            untilStopWord();
        }
    }
}
