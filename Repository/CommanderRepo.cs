using System.Collections.Generic;
using System.Linq;
using MyApp.Exceptions;
using MyApp.Models;

namespace MyApp.Repository
{
    public class CommanderRepo : ICommanderRepo
    {
        private readonly harshaDBContext _context;

        public CommanderRepo(harshaDBContext context) => _context = context;

        public Command GetCommandById(int id) => _context.Commands.Where(p => p.Id == id)
                                                     .FirstOrFail($"Command with {id} is not found");

        public IEnumerable<Command> GetCommands() => _context.Commands;
    }
}