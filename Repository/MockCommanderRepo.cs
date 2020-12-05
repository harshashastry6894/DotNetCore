using System.Collections.Generic;
using System.Linq;
using MyApp.Models;

namespace MyApp.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private readonly harshaDBContext _context;

        public MockCommanderRepo(harshaDBContext context)
        {
            _context = context;
        }

        public Command GetCommandById(int id) => _context.Commands.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands;         
        }
    }
}