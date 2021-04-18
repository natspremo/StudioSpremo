using StudioSpremoBack.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class Job
  {
    [Key]
    public string Id { get; set; }
    public virtual int ServiceId
    {
      get
      {
        return (int)this.Service;
      }
      set
      {
        Service = (EService)value;
      }
    }
    [EnumDataType(typeof(EService))]
    public EService Service { get; set; }
    public DateTime OrderedTime { get; set; }
    public string RadniNalog { get; set; }      // tata dodaje sam nalog (kada pravi otpremnicu)
    public string JobName { get; set; }
    public string Note { get; set; }
    public int Liniature { get; set; }
    public bool IsDone { get; set; }
    public bool OverprintBlack { get; set; }
    public bool Prepress { get; set; }
    public bool CourierIncluded { get; set; }
  }
}
