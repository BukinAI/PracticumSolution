
using Business.Abstraction;
using DataAccess.Abstraction;
using Models;

namespace Business
{
    public class LibraryCardService : ILibraryCardService
    {
        private ILibraryCardDao libraryCardDao;
        public LibraryCardService(ILibraryCardDao libraryCardDao)
        {
            this.libraryCardDao = libraryCardDao;
        }

        public List<LibraryCard> GetAll()
        {
            return libraryCardDao.GetAll();
        }

        public void Save(LibraryCard LibraryCard)
        {
            libraryCardDao.Save(LibraryCard);
        }
    }
}
