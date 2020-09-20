using System.Collections.Generic;
using CommanderApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommanderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            
        }

        [HttpGet]
        public ActionResult<Command> GetCommandById(int Id)
        {

        }
    }
}