using System.Collections.Generic;
using System.Linq;
using AppCommander.Models;

namespace AppCommander.Data
{
  public class SqlAppCommanderRepo : IAppCommanderRepo
  {
    private readonly AppCommanderContext _context;

    public SqlAppCommanderRepo(AppCommanderContext context)
    {
      _context = context;
    }
    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }
  }
}