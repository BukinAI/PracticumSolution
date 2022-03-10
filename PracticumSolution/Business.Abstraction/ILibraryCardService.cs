
using Models;

namespace Business.Abstraction
{
    public interface ILibraryCardService
    {
        List<LibraryCard> GetAll();

        void Save(LibraryCard LibraryCard);
    }
}
