using System;
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

    public void CreateCommand(Command cmd)
    {
      if (cmd == null)
      {
        throw new ArgumentNullException(nameof(cmd));
      }
      _context.Commands.Add(cmd);
    }

    public IEnumerable<Command> GetAllCommands()
    {
      return _context.Commands.ToList();
    }

    public Command GetCommandById(int id)
    {
      return _context.Commands.FirstOrDefault(p => p.Id == id);
    }

    public bool SaveChanges()
    {
      return (_context.SaveChanges() >= 0);
    }
  }
}