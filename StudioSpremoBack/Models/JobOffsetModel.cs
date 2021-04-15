using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobOffsetModel
  {
    public string Id { get; set; }
    public string PlateDimensionId { get; set; }
    public virtual PlateDimension PlateDimension { get; set; }
    public string JobId { get; set; }
    public virtual Job Job { get; set; }
    public int PlateSum { get; set; }
    public int BrOtpremnice { get; set; }
  }
}
