using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class EFProductsRepository : IProductRepository
    {
        public EFProductsRepository(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<Product> Products => _ctx.Products;

        public ApplicationDBContext _ctx { get; private set; }
    }
}
