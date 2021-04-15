using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class ClientModel
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string AddressId { get; set; }
    public virtual Address Address { get; set; }
    public int CompanyId { get; set; }
    public virtual Company Company { get; set; }
  }
}
