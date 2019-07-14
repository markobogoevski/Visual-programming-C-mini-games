using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class DutchRepository : IDutchRepository
    {
        private readonly DutchContext _ctx;

        public DutchRepository(DutchContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Order> GetAllOrders(bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
                return _ctx.Orders.ToList();
        }

        public IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                    .Where(o=>o.User.UserName==username)
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
                return _ctx.Orders
                    .Where(o => o.User.UserName == username)
                    .ToList();
        }


        public Order GetOrderById(string username,int id)
        {
            return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id&& o.User.UserName == username)
                .FirstOrDefault();
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _ctx.Products
                .OrderBy(p => p.Title);
        }


        public IEnumerable<Product> GetProductsByCategory(string cat)
        {
            return _ctx.Products
                .Where(p => p.Category == cat);
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0;
        }



        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        
    }
}
