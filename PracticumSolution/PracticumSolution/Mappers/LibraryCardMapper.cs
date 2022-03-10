using Models;
using Models.Dto;

namespace BookHouse.Mappers
{
    public static class LibraryCardMapper
    {
        public static LibraryCard MapToModel(LibraryCardDto libraryCardDto) 
        {
            return new LibraryCard
            {
                Reader = HumanMapper.MapToModel(libraryCardDto.Reader),
                Books = libraryCardDto.Books.Select(BookMapper.MapToModel).ToList()
            };

            
        }
    }
}
