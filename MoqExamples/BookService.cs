using System;
using System.Collections.Generic;
using System.Linq;

namespace MoqExamples
{
    public class BookService
    {
        private IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public List<Book> SoldBooks()
        {
            var books = _repository.GetSoldBooks().ToList();

            if (books.Count == 0)
            {
                return new List<Book>();
            }

            else
            {
                return books;
            }
        }

        public string BookTitle(string name)
        {
            try
            {
                var title = _repository.GetBookByTitle(name);

                return title;
            }

            catch (ArgumentNullException)
            {
                return "Book does not exists";
            }
        }

        public void Delete(int id)
        {
            try
            {
                _repository.DeleteBook(id);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Book does not exists");
            }
        }
    }
}
