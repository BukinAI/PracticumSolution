using DataAccess.Abstraction;
using Models;

namespace DataAccess
{
    public class LibraryCardDao : ILibraryCardDao
    {
        public List<LibraryCard> GetAll()
        {
            return LibraryCards.libraryCardList;
        }

        public void Save(LibraryCard LibraryCard)
        {
            LibraryCards.libraryCardList.Add(LibraryCard);
        }
    }
}
