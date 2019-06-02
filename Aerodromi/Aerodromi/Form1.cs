using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodromi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            if (lbAirports.SelectedIndex != -1)
            {
                Aiport aiport = (Aiport)lbAirports.SelectedItem;
                lbDestinations.Items.Clear();
                foreach (Destination destination in aiport.destinations)
                    lbDestinations.Items.Add(destination);

                if (aiport.destinations.Count >= 1)
                {
                    Destination expensive = aiport.mostExpensiveDestination();
                    textBox1.Text = expensive.ToString();
                    textBox2.Text = aiport.averageLen().ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            else
            {
                lbDestinations.Items.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            Nov_aerodrom nov = new Nov_aerodrom();
            DialogResult result = nov.ShowDialog();

            if (result == DialogResult.OK)
                lbAirports.Items.Add(nov.airport);
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAirports.SelectedIndex != -1)
            {
                btnRemoveAirport.Enabled = true;
                btnAddDestination.Enabled = true;
            }
            else
            {
                btnRemoveAirport.Enabled = false;
                btnAddDestination.Enabled = false;
                return;
            }


            update();
        }

        private void btnRemoveAirport_Click(object sender, EventArgs e)
        {
            Deletion_notice deletion = new Deletion_notice();
            DialogResult result = deletion.ShowDialog();
            if (result == DialogResult.Yes)
            {
                if (lbAirports.SelectedIndex != -1)
                {
                        Aiport aiport = (Aiport)lbAirports.SelectedItem;
                        aiport.destinations.Clear();
                        

                    lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
                    update();
                }
                btnRemoveAirport.Enabled = false;
            }

           
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            Nova_destinacija nova_Destinacija = new Nova_destinacija();
            DialogResult result = nova_Destinacija.ShowDialog();
            if (result == DialogResult.OK)
                lbDestinations.Items.Add(nova_Destinacija.destination);

            Aiport selected = (Aiport)lbAirports.SelectedItem;
            selected.addDestination(nova_Destinacija.destination);

            update();
        }
    }
}
