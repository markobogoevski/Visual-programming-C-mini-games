using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void updateFields()
        {

            Car mostExpensive = (Car)lbCars.Items[0];
            Car mostEconomic = (Car)lbCars.Items[0];

            decimal averageCost = 0;
            foreach(Car car in lbCars.Items)
            {
                averageCost += car.Cena;
                if (car.Cena > mostExpensive.Cena)
                    mostExpensive = car;
                if (car.Potroshuvacka < mostEconomic.Potroshuvacka)
                    mostEconomic = car;
            }
            averageCost /= lbCars.Items.Count;
            tbAvgCost.Text = String.Format("{0:0}", averageCost);
            tbMostExpensive.Text = mostExpensive.ToString();
            tbEconomic.Text = mostEconomic.ToString();
        }
      
   
        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (tbModel.Text.Length == 0)
            {
                message = "You must enter the car's model!";
                errorProvider1.SetError(tbModel, message);
                e.Cancel = true;
            }
            else
            errorProvider1.SetError(tbModel, message);
        }

        private void cbMarka_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (cbMarka.Text.Length == 0)
            {
                message = "You must enter the car's brand!";
                errorProvider1.SetError(cbMarka, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(cbMarka, message);
        }

        private void nudCost_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (nudCost.Value<100)
            {
                message = "Car's cost must be above 100!";
                errorProvider1.SetError(nudCost, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(nudCost, message);
        }

        private void nudPrice_Validating(object sender, CancelEventArgs e)
        {
            string message = "";
            if (nudPrice.Value < 100)
            {
                message = "Car's price must be above 100!";
                errorProvider1.SetError(nudPrice, message);
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(nudPrice, message);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("You must enter all the fields!");
                return;
            }
            else
            {
                Car car = new Car(cbMarka.Text, tbModel.Text, nudCost.Value, nudPrice.Value);
                lbCars.Items.Add(car);
                if (lbCars.Items.Count != 0)
                    updateFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedIndex != -1)
            {
                lbCars.Items.RemoveAt(lbCars.SelectedIndex);
                btnDelete.Enabled = false;
                tbModel.Clear();
                nudCost.ResetText();
                nudPrice.ResetText();
                if(lbCars.Items.Count!=0)
                updateFields();
            }
        }

        private void lbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCars.SelectedIndex != -1)
            {
                btnDelete.Enabled = true;
            }
            else
                btnDelete.Enabled = false;
        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            Marka marka = new Marka();
            DialogResult = marka.ShowDialog();
            if(DialogResult == DialogResult.OK)
            {
                lbMarki.Items.Add(marka.novaMarka);
                cbMarka.Items.Add(marka.novaMarka);
                cbMarka.Enabled = true;
            }
        }

        private void cbMarka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

         

        private void nudCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("eve");
        }
    }
}
