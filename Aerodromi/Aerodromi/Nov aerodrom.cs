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
    public partial class Nov_aerodrom : Form
    {
        public Aiport airport { get; set; }
        public Nov_aerodrom()
        {
            InitializeComponent();
        }

        private void tbCityName_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbCityName.Text.Length == 0&&letterCheck(tbCityName.Text))
            {
                message = "You must enter the city name!";
                errorProvider1.SetError(tbCityName, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(tbCityName, message);
        }

        private void tbAirportName_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbAirportName.Text.Length == 0&&letterCheck(tbAirportName.Text))
            {
                message = "You must enter the airport name!";
                errorProvider2.SetError(tbAirportName, message);
                e.Cancel = true;
            }
            else
                errorProvider2.SetError(tbAirportName, message);
        }

        private bool letterCheck(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if (!char.IsLetter(text[i]))
                    return false;

            return true;
        }

        private void tbAbbr_Validating(object sender, CancelEventArgs e)
        {
            String message = "";
            if (tbAbbr.Text.Length!=3||!upperCheck(tbAbbr.Text))
            {
                message = "Invalid abbreviation - must be exactly 3 upper letters";
                errorProvider3.SetError(tbAbbr, message);
                e.Cancel = true;
            }
            else
                errorProvider3.SetError(tbAbbr, message);
        }

        private bool upperCheck(string text)
        {
            for (int i = 0; i < text.Length; i++)
                if (!char.IsLetter(text[i]) || char.IsLower(text[i]))
                    return false;

            return true;
        }

        private void btnSubmitAirport_Click(object sender, EventArgs e)
        {
            if (tbAirportName.Text.Length == 0 || tbCityName.Text.Length == 0 || tbAbbr.Text.Length == 0)
                MessageBox.Show("You must enter all fields first!");
            else
            {
                String cityName = tbCityName.Text;
                String airportName = tbAirportName.Text;
                String abbr = tbAbbr.Text;
                airport = new Aiport(cityName, airportName, abbr, new List<Destination>());
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelAirport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
