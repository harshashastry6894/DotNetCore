using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        // public Command GetCommandById(int id) =>


        public IEnumerable<Command> GetCommands()
        {
            var context = new harshaDBContext();
            return context.Commands;            
        }
    }
}