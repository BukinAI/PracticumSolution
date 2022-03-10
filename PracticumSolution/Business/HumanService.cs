using Business.Abstraction;
using DataAccess.Abstraction;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class HumanService : IHumanService
    {
        private readonly IHumanDao humanDao;
        public HumanService(IHumanDao humanDao)
        {
            this.humanDao = humanDao;
        }
            
        public List<Human> GetAll()
        {
            return humanDao.GetAll();
        }

        public List<Human> GetAllAuthors()
        {
            return humanDao.GetAllAuthors();
        }

        public List<Human> GetByQuery(string query)
        {
            return humanDao.GetByQuery(query);
        }

        public Human? GetById(int id)
        {
            return humanDao.GetById(id);
        }
    
        public void Save(Human human)
        {
            humanDao.Save(human);
        }

        public void Update(Human human)
        {
            humanDao.Update(human);
        }

        public void DeleteById(int id)
        {
            humanDao.DeleteById(id);
        }
    }
}
