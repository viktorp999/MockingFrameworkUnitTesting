using Moq;
using MoqExamples;
using NUnit.Framework;
using System.Collections.Generic;

namespace MoqExamplesUnitTests
{
    [TestFixture]
    public class BookServiceTests
    {
        private Mock<IBookRepository> _repository;
        private BookService _service;
        private List<Book> _books;
        private List<Book> _emtylist;

        [SetUp]
        public void SetUp()
        {
            _repository = new Mock<IBookRepository>();
            _service = new BookService(_repository.Object);
            _emtylist = new List<Book>();
            _books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "A",
                    Pages = 1,
                    IsSold = true
                },

                new Book
                {
                    Id = 2,
                    Title = "B",
                    Pages = 2,
                    IsSold = true
                },
            };
        }

        [Test]
        public void SoldBooks_NoSoldBooks_ReturnEmptyList()
        {
            _repository.Setup(x => x.GetSoldBooks()).Returns(_emtylist);

            var result = _service.SoldBooks();

            Assert.That(result, Is.EqualTo(_emtylist));
        }

        [Test]
        public void SoldBooks_HaveSoldBooks_ReturnListOfSoldBooks()
        {
            _repository.Setup(x => x.GetSoldBooks()).Returns(_books);

            var result = _service.SoldBooks();

            Assert.That(result, Is.EqualTo(_books));
        }

        [Test]
        public void BookTitle_WhenCalled_ReturnBookTitle()
        {
            _repository.Setup(x => x.GetBookByTitle("A")).Returns(_books[0].Title);

            var result = _service.BookTitle("A");

            Assert.That(result, Is.EqualTo(_books[0].Title));
        }


        [Test]
        public void Delete_WhenCalled_DeleteBookFromList()
        {
            _repository.Setup(x => x.DeleteBook(It.IsAny<int>()));

            _service.Delete(1);

            _repository.Verify(x => x.DeleteBook(It.IsAny<int>()), Times.Once);
        }
    }
}
