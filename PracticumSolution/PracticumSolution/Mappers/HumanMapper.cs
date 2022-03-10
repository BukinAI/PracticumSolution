using Models;
using Models.Dto;

namespace BookHouse.Mappers
{
    public static class HumanMapper
    {
        public static Human MapToModel(HumanDto humanDto)
        {
            return new Human 
            { 
                Id = humanDto.Id, 
                Name = humanDto.Name, 
                SurName = humanDto.SurName, 
                Patronymic = humanDto.Patronymic, 
                Birthday = humanDto.Birthday 
            };


        }
    }
}
