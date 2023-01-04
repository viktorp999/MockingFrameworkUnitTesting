using System.Collections.Generic;

namespace MoqExamples
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetSoldBooks();
        string GetBookByTitle(string name);
        void DeleteBook(int id);
    }
}
