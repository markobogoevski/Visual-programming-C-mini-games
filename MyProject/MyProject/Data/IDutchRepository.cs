using System.Collections.Generic;
using DutchTreat.Data.Entities;

namespace MyProject.Data
{
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string cat);

        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string name, int id);

        bool SaveAll();
        void AddEntity(object model);
        
    }
}