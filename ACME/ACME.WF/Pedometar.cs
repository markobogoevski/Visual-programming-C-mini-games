using ACME.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME.WF
{
    public partial class Pedometar : Form
    {
        public Pedometar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = (decimal)0;
            try
            {
                result = customer.CalculatePercentOfGoalSteps(this.GoalStepBox.Text, this.ActualStepBox.Text);
                this.resultLabel.Text = $"You reached {result:N1}% of your goal today!";
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
