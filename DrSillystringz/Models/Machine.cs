using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DrSillystringz.Models
{
  public class Machine
  {
    public Machine()
    {
      this.Engineer = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public ICollection<EngineerMachine> Engineer { get; }
  }
}