using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class Client : IdentityUser
  {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string AddressId { get; set; }
    [ForeignKey("AddressId")]
    public virtual Address Address { get; set; }
    public int CompanyId { get; set; }
    [ForeignKey("CompanyId")]
    public virtual Company Company { get; set; }
  }
}
