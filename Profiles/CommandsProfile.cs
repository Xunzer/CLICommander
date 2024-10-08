using AutoMapper;
using CLICommander.Dtos;
using CLICommander.Models;

namespace CLICommander.Profiles
{   
    // map the Command model to Dtos. We inherit base class Profile from AutoMapper namespace. Provide a base for calling Map<?>()
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {   
            // logic for CreateMap: <Source -> Target>

            // map from Command to ReadDto using AutoMapper (for GET)
            CreateMap<Command, CommandReadDto>();

            // map the created Dto to an actual Command object (for POST)
            CreateMap<CommandCreateDto, Command>();

            // map the update Dto to a Command object (for PUT)
            CreateMap<CommandUpdateDto, Command>();

            // map the Command object to an update Dto (for PATCH)
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}