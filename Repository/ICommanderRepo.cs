using System.Collections.Generic;
using MyApp.Models;

namespace MyApp.Repository
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);     
    }
}