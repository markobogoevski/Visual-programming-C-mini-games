using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async IActionResult Index3()
        {
            long? length = await My
        }
        public ViewResult Index2()
        {
            var collection = new object[] { "something", 123, 123M, 231M, 1.4f, 21.3d };
            decimal total = 0;
            foreach (var item in collection)
            {
                if (item is decimal d)
                    total += d;
            }
            return View(@"Total : {total}");
        }

        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (var product in Product.GetProducts())
            {
                string name = product?.Name??"No Name";
                decimal? price = product?.Price??0M;
                string relatedName = product?.Related?.Name ?? "No related name";
                decimal? relatedPrice = product?.Related?.Price??0M;

                results.Add($"Name: {name}, Price: {price}, Related Name: {relatedName}, Related Price: {relatedPrice}");
            }

            return View(results);
        }
    }
}