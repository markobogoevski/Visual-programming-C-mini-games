using ACME.BL;
using ACME.Common;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();
        }

        private void PlaceOrder()
        {
            //getting UI info (customer, order and payment)
            var customer = new Customer();
            var order = new Order();
            var payment = new Payment();

            var wantSplitOrder = true;
            var wantReceipt = true;

            //placing an order
            var orderController = new OrderController();
            try
            {
                orderController.PlaceOrder(customer, order, payment, wantSplitOrder, wantReceipt);
            }catch(ArgumentNullException ex)
            {

            }
        }

       
    }
}
