
using Models;

namespace Business
{
    internal static class BookListExtension
    {
        public static void SortByAuthor(this List<Book> bookList)
        {
            bookList.Sort(delegate (Book x, Book y)
            {
                return x.Author.Id.CompareTo(y.Author.Id);
            });
        }

        public static void SortByTitle(this List<Book> bookList)
        {
            bookList.Sort(delegate (Book x, Book y)
            {
                return x.Title.CompareTo(y.Title);
            });
        }

        public static void SortByGenre(this List<Book> bookList)
        {
            bookList.Sort(delegate (Book x, Book y)
            {
                return x.Genre.CompareTo(y.Genre);
            });
        }
    }
}
