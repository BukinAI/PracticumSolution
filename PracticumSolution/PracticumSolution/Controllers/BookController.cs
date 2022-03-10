using Business.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Dto;
using BookHouse.Mappers;

namespace BookHouse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        /// <summary>
        /// 1.4.1.1 - Метод GET возвращающий Список всех книг
        /// </summary>
        [HttpGet("GetAll")]
        public List<Book> GetAll(string? sortType)
        {
            return bookService.GetAll(sortType);
        }

        /// <summary>
        /// 1.4.1.2 - Метод GET возвращающий Список всех книг по автору
        /// </summary>
        [HttpGet("GetByAuthorId")]
        public List<Book> GetByAuthorId(int id)
        {
            return bookService.GetByAuthorId(id);
        }

        /// <summary>
        /// 1.4.2 - Метод POST добавляющий новую книгу
        /// </summary>
        [HttpPost]
        public void Save(BookDto bookDto)
        {
            var book = BookMapper.MapToModel(bookDto);
            bookService.Save(book);
        }

        /// <summary>
        /// 1.4.3 - Метод DELETE удаляющий книгу
        /// </summary>
        [HttpDelete]
        public void DeleteById(int id)
        {
            bookService.DeleteById(id);
        }

        
    }
}
