using System.Collections.Generic;
using CommanderApi.Models;

namespace CommanderApi.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}