using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class JobOffset : Job
  { 
    public string PlateDimensionId { get; set; }
    [ForeignKey("PlateDimensionId")]
    public virtual PlateDimension PlateDimension { get; set; }
    public int PlateSum { get; set; }
    public int BrOtpremnice { get; set; }

    public virtual ICollection<FilesOffset> FilePaths { get; set; }
  }
}
