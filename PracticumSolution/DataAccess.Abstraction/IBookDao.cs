using Models;

namespace DataAccess.Abstraction
{
    public interface IBookDao
    {
        List<Book> GetAll();

        List<Book> GetByTitle(string title);

        List<Book> GetByAuthorId(int id);

        Book? GetById(int id);

        void Save(Book book);

        void Update(Book book);

        void DeleteById(int id);
    }
}