using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public class MockCommanderRepo : ICommandRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kattle & Pan"};
        }
    }
}