using Microsoft.AspNetCore.Identity;
using StudioSpremoBack.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class User : IdentityUser
  {
    public virtual int RoleId
    {
      get
      {
        return (int)this.Role;
      }
      set
      {
        Role = (ERole)value;
      }
    }
    [EnumDataType(typeof(ERole))]
    public ERole Role { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
  }
}
