using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver newForm = new AddDriver();
            DialogResult = newForm.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                lbDrivers.Items.Add(newForm.driver);
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Дали сте сигурен дека сакате да го избришете возачот?", "Бришење на возач", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.Yes)
                {
                    Driver driver = (Driver)lbDrivers.SelectedItem;
                    driver.Laps.Clear();
                    refreshLapsAndInfo();
                    textBox1.Clear();
                    lbDrivers.Items.RemoveAt(lbDrivers.SelectedIndex);
                    btnDeleteDriver.Enabled = false;
                }
            }
        }

        private void lbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                btnDeleteDriver.Enabled = true;
                textBox1.Clear();
                refreshLapsAndInfo();
            }
            else
            btnDeleteDriver.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 60)
            {
                numericUpDown1.Value++;
                numericUpDown2.Value = 0;
            }
            if(numericUpDown2.Value==-1)
            {
                if (numericUpDown1.Value > 0)
                {
                    numericUpDown2.Value = 59;
                    numericUpDown1.Value--;
                }
                else
                    numericUpDown2.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbDrivers.SelectedIndex != -1)
            {
                int minutes;
                int.TryParse(numericUpDown1.Value.ToString(), out minutes);

                int seconds;
                int.TryParse(numericUpDown2.Value.ToString(), out seconds);

                Lap lap = new Lap(seconds, minutes);
                Driver driver = (Driver)lbDrivers.SelectedItem;
                driver.addLap(lap);
                textBox1.Text = driver.bestLap().ToString();
                refreshLapsAndInfo();
            }
            else
                MessageBox.Show("Select a driver first!");
        }

        private void refreshLapsAndInfo()
        {
            if(lbDrivers.SelectedIndex!=-1)
            {
                lbLaps.Items.Clear();
                Driver driver = (Driver)lbDrivers.SelectedItem;
                if (driver.Laps.Count != 0)
                {
                    foreach (Lap lap in driver.Laps)
                    {
                        if(lap.lapToSeconds()>=(int)numericUpDown3.Value)
                        lbLaps.Items.Add(lap);
                    }

                    Lap bestLap = driver.bestLap();
                    if (bestLap != null)
                        textBox1.Text = driver.bestLap().ToString();
                    else
                        textBox1.Clear();
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            refreshLapsAndInfo();
        }
    }
}
