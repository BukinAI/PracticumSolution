
using Models;

namespace DataAccess.Abstraction
{
    public interface ILibraryCardDao
    {
        List<LibraryCard> GetAll();

        void Save(LibraryCard LibraryCard);
    }
}
