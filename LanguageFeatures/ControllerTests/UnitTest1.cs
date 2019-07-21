using System;
using Xunit;
using LanguageFeatures.Models;
using Moq;

namespace ControllerTests
{
    public class UnitTest1
    {
        [Theory]
        [ClassData(typeof(ProductTestData))]
        public void IndexActionModelIsComplete(Product[]products)
        {
            //Arrange
            var mock = new Mock<IRepository>();
            mock.SetupGet(m => m.GetProducts).Returns(products);
            //Act
            //Assert
        }
    }
}
