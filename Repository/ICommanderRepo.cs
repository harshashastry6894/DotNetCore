using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Repository
{
    public interface ICommanderRepo
    {
         IEnumerable<Command> GetCommands();
         Command GetCommandById(int id);   
         void CreateCommand(Command command);
         void UpdateCommand(int id, Command command); 
    }
}