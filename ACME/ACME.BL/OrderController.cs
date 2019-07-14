using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class OrderController
    {
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }
        private InventoryRepository inventoryRepository { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            emailLibrary = new EmailLibrary();
            inventoryRepository = new InventoryRepository();
        }

        public OperationResult PlaceOrder(
            Customer customer,
            Order order, 
            Payment payment,
            bool wantSplitOrder,
            bool wantReceipt) 
        {

            if (customer == null) throw new ArgumentNullException("Customer instance is null!");
            if (order == null) throw new ArgumentNullException("Order instance is null!");
            if (payment == null) throw new ArgumentNullException("Payment instance is null!");

            var result = new OperationResult();

            //saving customer and order
            customerRepository.Add(customer);
            orderRepository.Add(order);

            //if valid continue on 
            //ordering inventory
            inventoryRepository.OrderItems(order, wantSplitOrder);
           
            //processing payment
            payment.ProcessPayment();

            //send an optional email
            if (wantReceipt)
            {
                    var operation=customer.ValidateEmail();
                    if (operation.Success)
                    {
                        customerRepository.Update();
                        emailLibrary.SendEmail(customer.Email, "Email sent!");
                    }
                    else
                    {
                        if(result.Report.Any())
                        result.Report.AddRange(operation.Report);
                    }
            }

            return result;
        }

        private static void UpdateTrace(OperationResult result, OperationResult operation)
        {
            result.Success = false;
            result.Report.AddRange(operation.Report);
        }
    }
}
