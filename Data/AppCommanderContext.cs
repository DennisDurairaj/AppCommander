using AppCommander.Models;
using Microsoft.EntityFrameworkCore;

namespace AppCommander.Data
{
  public class AppCommanderContext : DbContext
  {
    public AppCommanderContext(DbContextOptions<AppCommanderContext> opt) : base(opt)
    {

    }

    public DbSet<Command> Commands { get; set; }
  }
}