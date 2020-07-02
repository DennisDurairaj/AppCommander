using System.Collections.Generic;
using AppCommander.Models;

namespace AppCommander.Data
{
  public interface IAppCommanderRepo
  {
    bool SaveChanges();
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int id);
    void CreateCommand(Command cmd);
  }
}