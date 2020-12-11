using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyApp.Dtos.Params;
using MyApp.Dtos.Rest;
using MyApp.Models;
using MyApp.Repository;

namespace MyApp.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandRest>> GetCommands() => Ok(_repository.GetCommands());

        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<CommandRest> GetCommandById(int id) => Ok(_mapper.Map<CommandRest>(_repository.GetCommandById(id)));

        //GET api/commands/5
        [HttpPost]
        public ActionResult<CommandRest> CreateCommand(CommandParams command)
        {
            var commandModel = _mapper.Map<Command>(command);
            _repository.CreateCommand(commandModel);
            return Ok(_mapper.Map<CommandRest>(commandModel));
        }

        [HttpPut("{id}")]
        public ActionResult<CommandRest> UpdateCommand(int id, CommandParams command)
        {
            var commandModel = _repository.GetCommandById(id);
            _mapper.Map(command, commandModel);
            _repository.UpdateCommand(id, commandModel);
            return NoContent();
        }
    }
}