using NUnit.Framework;
using SportsStore.Controllers;
using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FluentAssertions;
using SportsStore.Models.ViewModels;

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
            var viewModel = productController.List().ViewData.Model as ProductsListViewModel;
            var model = viewModel.Products;

            //Assert
            var productArray = model.ToArray();
            productArray.Should().HaveCount(4);
            productArray.Should().BeEquivalentTo(mockRepository.Products.Take(4), options =>
                 options.IncludingAllDeclaredProperties());
        }

        [Test]
        public void List_WhereWeSendPaginationViewModel_SentValidModel()
        {
            //Arrange
            var mockRepository = Mock.Create<IProductRepository>();
            Mock.Arrange(() => mockRepository.Products).Returns((new Product[]
            {
                new Product{ProductID=1,Name="P1"},
                new Product{ProductID=2,Name="P2"},
                new Product{ProductID=3,Name="P3"},
                new Product{ProductID=4,Name="P4"},
                new Product{ProductID=5,Name="P5"}
            }).AsQueryable);
            var controller = new ProductController(mockRepository) { PageSize = 3 };

            //Act
            var pagingModel = controller.List(2).ViewData.Model as ProductsListViewModel;
            var resultPage = pagingModel.PagingInfo;

            //Assert
            resultPage.Should().BeEquivalentTo(new PagingInfo
            {
                CurrentPage = 2,
                ItemsPerPage = 3,
                TotalItems = 5
            });
        }

        [Test]
        public void List_WithPageSize3_CanPaginateCorrectly()
        {
            //Arrange
            var mockRepository = Mock.Create<IProductRepository>();
            Mock.Arrange(() => mockRepository.Products).Returns((new Product[]
            {
                new Product{ProductID=1,Name="P1"},
                new Product{ProductID=2,Name="P2"},
                new Product{ProductID=3,Name="P3"},
                new Product{ProductID=4,Name="P4"},
                new Product{ProductID=5,Name="P5"}
            }).AsQueryable);
            var controller = new ProductController(mockRepository) { PageSize = 3 };

            //Act
            var pagingModel = controller.List(2).ViewData.Model as ProductsListViewModel;
            var resultProducts = pagingModel.Products.ToArray();

            //Assert
            resultProducts[0].Should().BeEquivalentTo(new Product { Name = "P4", ProductID = 4 });
            resultProducts[1].Should().BeEquivalentTo(new Product { Name = "P5", ProductID = 5 });
        }


    }
}