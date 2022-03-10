using Models;

namespace Business.Abstraction
{
    public interface IBookService
    {
        List<Book> GetAll(string sortType);

        List<Book> GetByTitle(string title);

        List<Book> GetByAuthorId(int id);

        Book? GetById(int  id);

        void Save(Book book);
                        
        void Update(Book book);

        void DeleteById(int id);
                
    }
}