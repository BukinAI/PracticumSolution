
namespace Models
{

    /// <summary>
    /// 1.2.2 Класс книга
    /// </summary>
    public class Book 
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public Human Author { get; set; }

        public string Genre { get; set; }
    }
}
