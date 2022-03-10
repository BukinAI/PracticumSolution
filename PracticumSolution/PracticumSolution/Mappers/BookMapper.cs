using Models;
using Models.Dto;

namespace BookHouse.Mappers
{
    public static class BookMapper
    {
        public static Book MapToModel(BookDto bookDto) 
        {
            return new Book
            {
                Author = HumanMapper.MapToModel(bookDto.Author),
                Title = bookDto.Title,
                Id = bookDto.Id,
                Genre = bookDto.Genre
            };

            
        }
    }
}
