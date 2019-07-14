using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACME.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.Common;

namespace ACME.BL.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTestValid()
        {
            //Arrange
            var orderController = new OrderController();
            var customer = new Customer() { Email = "markobogoevski@gmail.com" };
            var order = new Order();
            var payment = new Payment();
            //Act
            var actual = orderController.PlaceOrder(customer, order, payment,true, true);
            //Assert
            Assert.AreEqual(true, actual.Success);
            Assert.AreEqual(0, actual.Report.Count);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PlaceOrderTestCustomerIsNull()
        {
            //Arrange
            var orderController = new OrderController();
            Customer customer = null;
            var order = new Order();
            var payment = new Payment();
            //Act
            var actual = orderController.PlaceOrder(customer, order, payment, true, true);
            //Assert
            Assert.AreEqual(false, actual.Success);
            Assert.AreEqual(1, actual.Report.Count);
        }

    }
}