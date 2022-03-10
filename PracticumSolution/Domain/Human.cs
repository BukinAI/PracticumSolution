namespace Models
{

    /// <summary>
    /// 1.2.1 -Класс человека
    /// </summary>
    public class Human
    {
        public int Id { get; set; } 

        public bool IsAuthor { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public DateTime? Birthday { get; set; }

    }

}