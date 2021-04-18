using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class FilesFlexo
  {
    [Key]
    public string Id { get; set; }
    public string JobId { get; set; }
    [ForeignKey("JobId")]
    public virtual JobFlexo Job { get; set; }
    public string FilePath { get; set; }
  }
}
