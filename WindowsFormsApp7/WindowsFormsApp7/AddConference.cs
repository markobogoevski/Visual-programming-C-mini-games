﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class AddConference : Form
    {
        public Conference conference { get; set; }
        public AddConference()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (textBox1.Text.Length == 0)
            {
                message = "Name mustn't be empty!";
                errorProvider1.SetError(textBox1, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(textBox1, message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("Enter all fields first");
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                conference=new Conference(textBox1.Text,(int)numericUpDown1.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
