using Business.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Dto;
using BookHouse.Mappers;
/// <summary>
/// 2.1.3 - Контроллер,отвечающий за получение книги человеком
/// </summary>

namespace BookHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryCardController : ControllerBase
    {
        private readonly ILibraryCardService libraryCardService;
        public LibraryCardController(ILibraryCardService libraryCardService)
        {
            this.libraryCardService = libraryCardService;
        }

        [HttpGet]
        public List<LibraryCard> GetAll()
        {
            return libraryCardService.GetAll();
        }

        /// <summary>
        /// 2.1.4 - Метод POST взятие книги читателем
        /// </summary>
        [HttpPost]
        public void Save(LibraryCardDto libraryCardDto)
        {
            var libraryCard = LibraryCardMapper.MapToModel(libraryCardDto);
            libraryCardService.Save(libraryCard);
        }

    }
}
