using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Enums
{
  public enum EService
  {
    [Display(Name = "Priprema")]
    Priprema,
    [Display(Name = "Osvetljavanje")]
    OsvetljavanjePloca,
    [Display(Name = "IzradaKlisea")]
    IzradaKlisea
  }
}
