using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using packtbookslibrary.Shared.Models;
using packtbookslibrary_api.Controllers;
using packtbookslibrary_api.Services;
using System.Collections.Generic;

namespace packtbookslibrary_api_Test
{
    public class Tests
    {
        private readonly Mock<IBookService> bookService = new Mock<IBookService>();

        private  List<Book> booksList = new List<Book>();

        [SetUp]
        public void Setup()
        {
            booksList.Add(new Book
            {
                Id = "1234",
                ISBNNumber = "",
                Title = "Designing API First Archtiecture",
                Description = "Book on API Architecture",
                Author = "public",
                AuthorName = "Subhajit"
            });
            booksList.Add(new Book
            {
                Id = "12345",
                ISBNNumber = "",
                Title = "C# 10 and .NET 6 – Modern Cross-Platform Development - Sixth Edition",
                Description = "C# 10 and .NET 6 – Modern Cross-Platform Development - Sixth Edition",
                Author = "public",
                AuthorName = "Mark J. Price"
            });
            bookService.Setup(c => c.GetBooksList()).Returns(booksList);

        }

        [Test]
        public void GetReturnsValidObjectForCorrectID()
        {
            // Arrange
            var controller = new BooksController(bookService.Object);
            // Act
            var actionResult = controller.Get("1234").Result;
            var contentResult = actionResult as OkObjectResult;
            var contentResultValue = contentResult.Value as Book;
            // Assert
            Assert.IsNotNull(contentResult.Value);
            Assert.True(contentResultValue.AuthorName == "Subhajit");
        }

        [Test]
        public void GetReturnsNullForIncorrectID()
        {
            // Arrange
            var controller = new BooksController(bookService.Object);
            // Act
            var actionResult = controller.Get("12341111").Result;
            var contentResult = actionResult as OkObjectResult;
            var contentResultValue = contentResult.Value as Book;
            // Assert
            Assert.IsInstanceOf<Book>(contentResult.Value);
            Assert.IsNull(contentResultValue.AuthorName);
        }
    }
}