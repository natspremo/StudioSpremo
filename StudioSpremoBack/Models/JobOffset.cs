using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobOffset
  {
    [Key]
    public string Id { get; set; }
    public string PlateDimensionId { get; set; }
    [ForeignKey("PlateDimensionId")]
    public virtual PlateDimension PlateDimension { get; set; }
    public string JobId { get; set; }
    [ForeignKey("JobId")]
    public virtual Job Job { get; set; }
    public int PlateSum { get; set; }
    public int BrOtpremnice { get; set; }
  }
}
