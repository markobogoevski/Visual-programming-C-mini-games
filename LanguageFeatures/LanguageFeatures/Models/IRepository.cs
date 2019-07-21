using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public interface IRepository
    {
         IEnumerable<Product> GetProducts();
         void AddProduct(Product p);
    }
}
