using AppCommander.Dtos;
using AppCommander.Models;
using AutoMapper;

namespace AppCommander.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
      CreateMap<Command, CommandReadDto>();
      CreateMap<CommandCreateDto, Command>();
    }
  }
}