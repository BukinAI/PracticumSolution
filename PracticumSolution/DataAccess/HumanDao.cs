using DataAccess.Abstraction;
using Models;

namespace DataAccess
{
    public class HumanDao : IHumanDao
    {
       
        public List<Human> GetAll()
        {
            return Humans.HumanList;
        }

        public List<Human> GetAllAuthors()
        {
            var findAuthors = Humans.HumanList.Where(human => human.IsAuthor );

            return findAuthors.ToList();
        }

        public Human? GetById(int id)
        {
            return Humans.HumanList.FirstOrDefault(human => human.Id == id);
        }

        public List<Human> GetByQuery(string query)

        {
            query = query.Trim();

            var findhumans = Humans.HumanList.Where(human =>
                human.Name.Contains(query) || 
                human.SurName.Contains(query) || 
                human.Patronymic.Contains(query));

            return findhumans.ToList();
        }

        public void Save(Human human)
        {
            Humans.HumanList.Add(human);
        }

        public void Update(Human human)
        {
            var findHuman = Humans.HumanList.FirstOrDefault(human =>  human.Equals(human));
            if (findHuman != null)
            {
                findHuman.Name = human.Name;
                findHuman.SurName = human.SurName;
                findHuman.Patronymic = human.Patronymic;
                findHuman.Birthday = human.Birthday;
            }
        }

        public void DeleteById(int id)
        {
            var findHuman = Humans.HumanList.FirstOrDefault(human => human.Id == id);
            if (findHuman != null) 
            {
                Humans.HumanList.Remove(findHuman);
            }
        }
    }


}
