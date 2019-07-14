using System;
using Xunit;

namespace CourseStart.Testing
{
    public class TypeTests
    {
        public delegate string WriteLogDelegate(string logMessage);
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            //arrange
            WriteLogDelegate log = returnMessage;
            //act
            var result = log("Hello");
            //assert
            Assert.Equal("Hello", result);
        }

        string returnMessage(string message)
        {
            return message;
        }

        [Fact]
        public void TestStrings()
        {
            //arrange
            string s1 = "Marko";
            string s2 = s1;
            s2 = "Darko";
            //act
            //assert

            Assert.Equal(s1,s1);
        }

    
        [Fact]
        public void Test1()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetNameGetName(book1, "New Book");
            //act
            //assert

            Assert.Equal("Book 1", book1.Name);
        }

        private void SetNameGetName(InMemoryBook book, string newName)
        {
            book = new InMemoryBook(newName);
        }


        [Fact]
        public void CanSetName()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(ref book1, "New Book");
            SetPages(book1, 120);
            //act
            //assert

            Assert.Equal("New Book", book1.Name);
            Assert.Equal(120, book1.pages);

        }

        private void SetPages(InMemoryBook book, int newPageCount)
        {
            book.setPages(newPageCount);
        }

        private void SetName(ref InMemoryBook book, string newName)
        {
            book.Name = newName ;
        }

        [Fact]
        public void TwoVarsCanReffSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;
            //act
            //assert
            Assert.Same(book1,book2);
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
