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

        public void CreateCommand(Command command)
        {
            _context.Commands.Add(command);
            _context.SaveChanges();
        }

        public void DeleteCommand(Command command)
        {
            _context.Commands.Remove(command);
            _context.SaveChanges();
        }

        public Command GetCommandById(int id) => _context.Commands.Where(p => p.Id == id)
                                                     .FirstOrFail($"Command with {id} is not found");

        public IEnumerable<Command> GetCommands() => _context.Commands;

        public void UpdateCommand(int id, Command command)
        {
            _context.SaveChanges();
        }
    }
}