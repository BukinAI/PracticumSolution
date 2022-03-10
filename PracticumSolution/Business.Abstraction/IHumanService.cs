using Models;

namespace Business.Abstraction
{
    public interface IHumanService                       
    {
        List<Human> GetAll();                           

        List<Human> GetAllAuthors();         

        List<Human> GetByQuery(string query);          

        Human? GetById(int id);

        void Save(Human human);                        

        void Update(Human human);                       

        void DeleteById(int id);
    }
}