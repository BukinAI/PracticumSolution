
using System.ComponentModel.DataAnnotations;

namespace Models.Dto
{

    /// <summary>
    /// 1.2.1 -Класс человека
    /// </summary>
    public class HumanDto
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string SurName { get; set; }
        
        [Required]
        public string Patronymic { get; set; }

        public DateTime? Birthday { get; set; }
    }
}
