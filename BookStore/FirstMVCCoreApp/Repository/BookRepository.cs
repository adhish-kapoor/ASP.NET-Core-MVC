using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Adi", Description = "This is MVC book", Category = ".NET", Language = "English", TotalPages = 300},
                new BookModel(){Id = 2, Title = "C#", Author = "Rak", Description = "This is C# book", Category = ".NET", Language = "English", TotalPages = 400},
                new BookModel(){Id = 3, Title = "C++", Author = "Sam", Description = "This is C++ book", Category = "Programming", Language = "English", TotalPages = 500},
                new BookModel(){Id = 4, Title = "Python", Author = "Daksh", Description = "This is Python book", Category = "Programming", Language = "English", TotalPages = 600},
                new BookModel(){Id = 5, Title = "JS", Author = "Adi", Description = "This is JavaScript book", Category = "Frontend Programming", Language = "English", TotalPages = 700}
            };
        }
    }
}
