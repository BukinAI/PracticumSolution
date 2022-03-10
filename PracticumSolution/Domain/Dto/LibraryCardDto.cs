
namespace Models.Dto
{
    /// <summary>
    /// 2.1.1 Агрегатор LibraryCard
    /// </summary>
    public class LibraryCardDto
    {
        public HumanDto Reader { get; set; }

        public List<BookDto> Books { get; set; }
    }
}
