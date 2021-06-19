using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class FlavorTreat
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}