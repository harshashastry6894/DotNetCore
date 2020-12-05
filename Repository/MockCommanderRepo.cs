using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        // public Command GetCommandById(int id) =>
        private readonly harshaDBContext _context;

        public MockCommanderRepo(harshaDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.Commands;         
        }
    }
}