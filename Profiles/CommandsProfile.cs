using AutoMapper;
using MyApp.Dtos.Rest;
using MyApp.Models;

namespace MyApp.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandRest>();
        }
    }

}