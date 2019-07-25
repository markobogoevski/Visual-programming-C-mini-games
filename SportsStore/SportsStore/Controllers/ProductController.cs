using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public int PageSize = 4;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ViewResult List(int pageNumber = 1) =>
            View(new ProductsListViewModel
            {
                Products = _productRepository.Products
                .OrderBy(p => p.ProductID)
                .Skip((pageNumber - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = PageSize,
                    TotalItems = _productRepository.Products.Count()
                }
            });
    }
}