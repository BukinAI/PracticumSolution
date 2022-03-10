
namespace Models
{
    /// <summary>
    /// 2.1.1 Агрегатор LibraryCard; 2.1.5 - Формат времени
    /// </summary>
    public class LibraryCard
    {
        public Human Reader { get; set; }

        public List<Book> Books { get; set; }
        
        public string DateTimeOffset { get; set; } = DateTime.Now.ToString("O");
    }
}
