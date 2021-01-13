using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DrSillystringz.Models
{
  public class DrSillystringzContext : DbContext
  {
    public virtual DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }

    public DrSillystringzContext(DbContextOptions options) : base(options) { }
  }
}