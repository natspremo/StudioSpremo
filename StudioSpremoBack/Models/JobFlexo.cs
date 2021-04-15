using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobFlexo
  {
    [Key]
    public string Id { get; set; }
    public string PolymerThicknessId { get; set; }
    [ForeignKey("PolymerThicknessId")]
    public virtual PolymerThickness PolymerThickness { get; set; }
    public string JobId { get; set; }
    [ForeignKey("JobId")]
    public virtual Job Job { get; set; }
    public DateTime OrderedTime { get; set; }
    public string MaterialType { get; set; }
    public bool Montage { get; set; }
    public int ObimValjka { get; set; }
    public double RollWidth { get; set; }
    public int SeparationSum { get; set; }
    public bool FileShortening { get; set; }
    public int BrOtpremnice { get; set; }

  }
}
