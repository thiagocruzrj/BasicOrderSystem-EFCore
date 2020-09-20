using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public class MockCommanderRepo : ICommandRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kattle & Pan"},
                new Command {Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife and chopping board"},
                new Command {Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in a cup", Platform = "Kattle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kattle & Pan"};
        }
    }
}