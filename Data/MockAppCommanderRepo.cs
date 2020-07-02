using System.Collections.Generic;
using AppCommander.Models;

namespace AppCommander.Data
{
  public class MockAppCommanderRepo : IAppCommanderRepo
  {
    public void CreateCommand(Command cmd)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command { Id = 0, HowTo = "Boil egg", Line = "Boil water", Platform = "Kettle and Pan" },
        new Command { Id = 1, HowTo = "Cut bread", Line = "Get knife", Platform = "Knife and chopping board" },
        new Command { Id = 2, HowTo = "Make tea", Line = "Cup", Platform = "Kettle and cup" }
      };
      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "Boil egg", Line = "Boil water", Platform = "Kettle and Pan" };
    }

    public bool SaveChanges()
    {
      throw new System.NotImplementedException();
    }
  }
}