

using System.ComponentModel.DataAnnotations;

namespace Models.Dto
{

    /// <summary>
    /// 1.2.2 Класс книга
    /// </summary>
    public class BookDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public HumanDto Author { get; set; }

        [Required]
        public string Genre { get; set; }
    }
}
