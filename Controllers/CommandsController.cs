using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
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

        //POST api/commands
        [HttpPost]
        public ActionResult<CommandRest> CreateCommand(CommandParams command)
        {
            var commandModel = _mapper.Map<Command>(command);
            _repository.CreateCommand(commandModel);
            return Ok(_mapper.Map<CommandRest>(commandModel));
        }

        //PUT api/commands/{id}
        [HttpPut("{id}")]
        public ActionResult<CommandRest> UpdateCommand(int id, CommandParams command)
        {
            var commandModel = _repository.GetCommandById(id);
            _mapper.Map(command, commandModel);
            _repository.UpdateCommand(id, commandModel);
            return NoContent();
        }

        //PATCH api/commands/{id}
        [HttpPatch("{id}")]
        public ActionResult<CommandRest> PartialCommandUpdate(int id, JsonPatchDocument<CommandParams> patchDoc)
        {
            var commandModel = _repository.GetCommandById(id);
            var commandToPatch = _mapper.Map<CommandParams>(commandModel);
            patchDoc.ApplyTo(commandToPatch, ModelState);
            if (!TryValidateModel(commandToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(commandToPatch, commandModel);
            _repository.UpdateCommand(id, commandModel);
            return NoContent();
        }

        //DELETE api/commands/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var commandModelFromRepo = _repository.GetCommandById(id);
            _repository.DeleteCommand(commandModelFromRepo);
            return NoContent();
        }
    }
}