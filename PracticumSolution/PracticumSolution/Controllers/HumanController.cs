using Business.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Dto;
using BookHouse.Mappers;

namespace BookHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanController : ControllerBase
    {
        private readonly IHumanService humanService;
        public HumanController(IHumanService humanService)
        {
            this.humanService = humanService;
        }

        /// <summary>
        /// 1.3.1.1 - Метод GET возвращающий Список всех людей
        /// </summary>
        [HttpGet("GetAll")]
        public List<Human> GetAll()
        {
            return humanService.GetAll();
        }

        /// <summary>
        /// 1.3.1.2 - Метод GET возвращающий Список людей, которые пишут книги
        /// </summary>
        [HttpGet("GetAllAuthors")]
        public List<Human> GetAllAuthors()
        {
            return humanService.GetAllAuthors();
        }

        // <summary>
        /// 1.3.1.3 - Метод GET возвращающий Список людей по поисковой фразе(query)
        /// </summary>
        [HttpGet("GetByQuery")]
        public List<Human> GetByQuery(string query)
        {
            return humanService.GetByQuery(query);
        }

        /// <summary>
        /// 1.3.2 - Метод POST добавляющий нового человека
        /// </summary>
        [HttpPost]
        public void Save(HumanDto humanDto)
        {
            var human = HumanMapper.MapToModel(humanDto);
            humanService.Save(human);
        }

        /// <summary>
        /// 1.3.3 - Метод DELETE удаляющий человека
        /// </summary>
        [HttpDelete]
        public void DeleteById(int id)
        {
            humanService.DeleteById(id);
        }
    }
}
