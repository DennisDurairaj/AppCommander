using System.Collections.Generic;
using AppCommander.Models;

namespace AppCommander.Data
{
  public interface IAppCommanderRepo
  {
    IEnumerable<Command> GetAppCommands();
    Command GetCommandById(int id);
  }
}