﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            int duration = (int)numericUpDown1.Value;
            double rating = double.Parse(textBox2.Text);
            Song newSong = new Song(name, duration, rating);
            listBox1.Items.Add(newSong);
        }
    }
}
