using NUnit.Framework;
using SportsStore.Controllers;
using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FluentAssertions;

namespace Tests
{
    public class ProductControllerTests
    {
        [Test]
        public void List_WherePageNumberIsDefault_ReturnsValidItems()
        {
            //Arrange
            var mockRepository = Mock.Create<IProductRepository>();
            Mock.Arrange(() => mockRepository.Products).Returns(new Product[]{
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
                }.AsQueryable<Product>);
            var productController = new ProductController(mockRepository);

            //Act
            var model = productController.List().ViewData.Model as IEnumerable<Product>;

            //Assert
            var productArray = model.ToArray();
            productArray.Should().HaveCount(4);
            productArray.Should().BeEquivalentTo(mockRepository.Products.Take(4), options =>
                 options.IncludingAllDeclaredProperties());
        }
    }
}