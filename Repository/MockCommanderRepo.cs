using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public Command GetCommandById(int id) =>
         new Command { Id = 1, HowTO = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" };

        public IEnumerable<Command> GetCommands()
        {
            return new List<Command>
            {
              new Command { Id = 1, HowTO = "Boil an egg", Line = "Boil Water", Platform = "Kettle & Pan" },
              new Command { Id = 2, HowTO = "Boil an Maggi", Line = "Boil Water", Platform = "Kettle & Pan" }
            };
        }
    }
}