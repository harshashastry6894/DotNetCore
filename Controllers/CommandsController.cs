using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    }
}