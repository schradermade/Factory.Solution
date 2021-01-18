using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DrSillystringz.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }

  }
}