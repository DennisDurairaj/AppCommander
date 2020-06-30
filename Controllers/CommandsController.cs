using System.Collections.Generic;
using AppCommander.Data;
using AppCommander.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCommander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly IAppCommanderRepo _repository;

    public CommandsController(IAppCommanderRepo repository)
    {
      _repository = repository;
    }
    //private readonly MockAppCommanderRepo _repository = new MockAppCommanderRepo();
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();
      return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}