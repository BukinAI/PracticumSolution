using DataAccess.Abstraction;
using Models;

namespace DataAccess
{
    public class BookDao : IBookDao
    {
        public void DeleteById(int id)
        {
            var findBook=Books.BookList.FirstOrDefault(book => book.Id == id);
            if (findBook != null)
            {
                Books.BookList.Remove(findBook);
            }
        }

        public List<Book> GetAll()
        {
            return Books.BookList;
        }

        public List<Book> GetByAuthorId(int id)
        {
            var findBook = Books.BookList.Where(book => book.Author.Id == id);
            return findBook.ToList();
        }

        public Book? GetById(int id)
        {
            return Books.BookList.FirstOrDefault(book => book.Id == id);
            
        }

        public List<Book> GetByTitle(string title)
        {
            var findBook = Books.BookList.Where(book => book.Title == title);
            return findBook.ToList();
        }

        public void Save(Book book)
        {
            Books.BookList.Add(book);
        }

        public void Update(Book book)
        {
            var findBook = Books.BookList.FirstOrDefault(book => book.Equals(book));
            if (findBook != null)
            {
                findBook.Title = book.Title;
                findBook.Genre = book.Genre;
            }
            
        }
    }
}
