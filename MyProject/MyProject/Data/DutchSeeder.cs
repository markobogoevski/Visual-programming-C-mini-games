using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using MyProject.Data.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<StoreUser> _userManager;

        public DutchSeeder(DutchContext ctx, IHostingEnvironment hosting,
            UserManager<StoreUser>userManager) //in order to fill the db context it must have it
        {
            _ctx = ctx;
            _hosting = hosting;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();

            StoreUser user = await _userManager.FindByEmailAsync("markobogoevski@gmail.com");
            if (user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Marko",
                    LastName = "Bogoevski",
                    Email = "markobogoevski@gmail.com",
                    UserName = "markobogoevski"
                };

                var result = await _userManager.CreateAsync(user, "Poptropicaata1*");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create new user in seeder!");
                }
            }

            if (!_ctx.Products.Any())
            {
                //   Need to create sample data!
                var filepathProd = Path.Combine(_hosting.ContentRootPath, "Data/art.json");

                var jsonProd = File.ReadAllText(filepathProd);

                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(jsonProd);

                _ctx.Products.AddRange(products);

                var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();
                if (order != null)
                {
                    order.User = user;
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product=products.First(),
                            Quantity=5,
                            UnitPrice=products.First().Price
                        }
                    };
                }
                _ctx.SaveChanges();
            }
        }
    }
}
