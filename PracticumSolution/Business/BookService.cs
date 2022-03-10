using Business.Abstraction;
using DataAccess.Abstraction;
using Models;

namespace Business
{
    public class BookService : IBookService
    {
        private readonly IBookDao bookDao;
        private readonly IHumanService humanService;
        public BookService(IBookDao bookDao, IHumanService humanService)
        {
            this.bookDao = bookDao;
            this.humanService = humanService;
        }

       
        public List<Book> GetAll(string sortType)
        {
            var allbook = bookDao.GetAll();

            if(sortType == "author")
            {
                allbook.SortByAuthor();
            }
            if (sortType == "genre")
            {
                allbook.SortByGenre();
            }
            if (sortType == "title")
            {
                allbook.SortByTitle();
            }
            return allbook;
        }

        public List<Book> GetByAuthorId(int id)
        {
            return bookDao.GetByAuthorId(id);
        }

        public Book? GetById(int id)
        {

            return bookDao.GetById(id);
        }

        public List<Book> GetByTitle(string title)
        {
            return bookDao.GetByTitle(title);
        }

        public void Save(Book book)
        {
            var human = humanService.GetById(book.Author.Id);

            if (human != null)
            {

                human.IsAuthor = true;

                book.Author = human;

                bookDao.Save(book);
            }
        }

        public void Update(Book book)
        {
            bookDao.Update(book);
        }
        public void DeleteById(int id)
        {
            bookDao.DeleteById(id);
        }
    }
}