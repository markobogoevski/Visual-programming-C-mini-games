using System;
using Xunit;

namespace CourseStart.Testing
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new InMemoryBook("");
            book.addGrade(89.1);
            book.addGrade(90.5);
            book.addGrade(77.3);
            //act
            var result=book.computeStatistics();
            //assert
            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5, result.High,1);
            Assert.Equal(77.3, result.Low,1);
        }
    }
}
