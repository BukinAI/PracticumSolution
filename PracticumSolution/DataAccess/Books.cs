using Models;

namespace DataAccess
{
    /// <summary>
    /// 1.2.3 - Статичный список книг
    /// </summary>
    public static class Books
    {
        public static List<Book> BookList = new List<Book>
        {
            new Book
            {
               Id = 1,
               Title = "Сборник сказок",
               Author = new Human {Id = 1, Name = "Александр", SurName = "Пушкин", Patronymic = "Сергеевич",IsAuthor = true},
               Genre = "Сказка"
            },
            new Book
            {
               Id = 2,
               Title = "Сборник стихов",
               Author = new Human{Id = 2,Name = "Михаил",SurName = "Лермонтов",Patronymic = "Юрьевич",IsAuthor = true},
               Genre = "Стихи"
            },
            new Book
            {
               Id = 3,
               Title = "Сборник детективов",
               Author = new Human{Id = 3,Name = "Агата",SurName = "Кристи",Patronymic = "Сергеевна",IsAuthor = true},
               Genre = "Детектив"
            }
        };

        /// <summary>
        /// 2.2.2 - Сортировка 
        /// </summary>
        public static void SortByAuthor()
        {
            BookList.Sort(delegate (Book x, Book y)
            {
                return x.Author.Id.CompareTo(y.Author.Id);
            });
        }

        public static void SortByTitle()
        {
            BookList.Sort(delegate (Book x, Book y)
            {
                return x.Title.CompareTo(y.Title);
            });
        }

        public static void SortByGenre()
        {
            BookList.Sort(delegate (Book x, Book y)
            {
                return x.Genre.CompareTo(y.Genre);
            });
        }
    }
}