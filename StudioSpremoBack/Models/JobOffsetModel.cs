using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobOffsetModel : JobModel
  {
    public string Id { get; set; }
    public string PlateDimensionId { get; set; }
    public virtual PlateDimension PlateDimension { get; set; }
    public int PlateSum { get; set; }
    public int BrOtpremnice { get; set; }
  }
}
