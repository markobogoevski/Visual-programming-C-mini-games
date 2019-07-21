using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool _InStock { get; }

        public Product(bool InStock=true)
        {
            _InStock = InStock;
        }

        public static Product[] GetProducts()
        {
            var kayak = new Product
            {
                Name = "Kayak",
                Price = 275M,
                Category = "Water Craft"
            };
            var lifejacket = new Product
            {
                Name = "Life jacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket,null };
        }
    }
}
