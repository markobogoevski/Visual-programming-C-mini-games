﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsValidating1
{
    public partial class FormUslovi : Form
    {
        public FormUslovi()
        {
            InitializeComponent();
        }

        private void FormUslovi_Load(object sender, EventArgs e)
        {
            tbUslovi.Text = "  USLOVI ";
            tbUslovi.Text += "za koristenje na programata XYZ ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
            tbUslovi.Text += "Bla bla bla bla-bla bla, bla bla bla. ";
        }

        private void FormUslovi_Resize(object sender, EventArgs e)
        {
             tbUslovi.Size = new System.Drawing.Size(this.Size.Width - 27, this.Size.Height - 48);
        }
    }
}
