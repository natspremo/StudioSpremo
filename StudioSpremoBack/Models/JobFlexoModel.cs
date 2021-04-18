using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobFlexoModel : JobModel
  { 
    public string PolymerThicknessId { get; set; }
    public virtual PolymerThickness PolymerThickness { get; set; }
    public string MaterialType { get; set; }
    public bool Montage { get; set; }
    public int ObimValjka { get; set; }
    public double RollWidth { get; set; }
    public int SeparationSum { get; set; }
    public bool FileShortening { get; set; }
    public int BrOtpremnice { get; set; }
  }
}
