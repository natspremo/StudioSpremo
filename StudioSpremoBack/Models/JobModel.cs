using StudioSpremoBack.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobModel
  {
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
    public EService Service { get; set; }
    public string RadniNalog { get; set; }
    public string JobName { get; set; }
    public DateTime OrderedTime { get; set; }
    public string Note { get; set; }
    public int Liniature { get; set; }
    public bool IsDone { get; set; }
    public bool OverprintBlack { get; set; }
    public bool Prepress { get; set; }
    public bool CourierIncluded { get; set; }
  }
}
