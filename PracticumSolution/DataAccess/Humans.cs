using Models;

namespace DataAccess
{
    /// <summary>
    /// 1.2.3 - Статичный список людей
    /// </summary>
    public static class Humans
    {
        public static List<Human> HumanList = new List<Human>
        {
            new Human{Id = 1, Name = "Александр", SurName = "Пушкин", Patronymic = "Сергеевич",IsAuthor = true},

            new Human{Id = 4, Name = "Иван", SurName = "Иванов", Patronymic = "Иванович", IsAuthor = false, Birthday = new DateTime(2000,10,10)},

            new Human{Id = 5, Name = "Петр", SurName = "Петров", Patronymic = "Петрович", IsAuthor = false, Birthday = new DateTime(1999,12,12)}
        };
    }
}
