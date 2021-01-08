using Microsoft.EntityFrameworkCore;

namespace DrSillystringz.Models
{
  public class DrSillystringzContext : DbContext
  {
    public DbSet<Engineer> Engineers { get; set; }
    //public DbSet<Machine> Machines { get; set; }
    //public DbSet<EngineerMachine> EngineerMachine { get; set; }

    public DrSillystringzContext(DbContextOptions options) : base(options) { }
  }
}