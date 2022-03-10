
using Models;

namespace DataAccess.Abstraction
{
    public interface IHumanDao
    {
        List<Human> GetAll();                          

        List<Human> GetAllAuthors();          

        List<Human> GetByQuery(string query);          

        Human? GetById(int id);

        void Save(Human human);
                
        void DeleteById(int id);

        void Update(Human human);
    }
}
