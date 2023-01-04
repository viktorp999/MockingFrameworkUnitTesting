using System.Collections.Generic;

namespace MoqExamples
{
    public static class BooksList
    {
        public static List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Programming",
                Pages = 200,
                IsSold = false
            },

            new Book
            {
                Id = 2,
                Title = "Unity3D",
                Pages = 344,
                IsSold = true
            },

            new Book
            {
                Id = 3,
                Title = "OOP Advanced",
                Pages = 160,
                IsSold = true
            },
        };
    }
}
