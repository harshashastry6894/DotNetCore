using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using MyApp.Repository;

namespace MyApp.Controllers
{
    // api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/commands
        [HttpGet]
        [Route("/")]
        public ActionResult<IEnumerable<Command>> GetCommands() => Ok(_repository.GetCommands());

        //GET api/commands/5
        [HttpGet]
        [Route("/{id}")]
        public ActionResult<Command> GetCommandById(int id) => Ok(_repository.GetCommandById(id));
    }
}