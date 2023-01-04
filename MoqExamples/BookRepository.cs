using System.Collections.Generic;
using System.Linq;

namespace MoqExamples
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetSoldBooks()
        {
            var soldbooks = BooksList.books.Where(b => b.IsSold == true);

            return soldbooks;
        }

        public string GetBookByTitle(string name)
        {
            var book = BooksList.books.First(b => b.Title == name);

            return book.Title;
        }

        public void DeleteBook(int id)
        {
            BooksList.books.RemoveAll(b => b.Id == id);
        }
    }
}
