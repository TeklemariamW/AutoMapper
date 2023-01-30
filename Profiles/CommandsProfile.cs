using AutoMapper;
using PizzaStore.Dtos;
using PizzaStore.Models;

namespace PizzaStore.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>(); // for reading
            CreateMap<CommandCreateDto, Command>(); // for creating
            CreateMap<CommandUpdateDto, Command>(); // for updating
        }
    }
}