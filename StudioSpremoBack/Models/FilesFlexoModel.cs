using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
  public class FilesFlexoModel
  {
    public string Id { get; set; }
    public string JobId { get; set; }
    public virtual JobFlexo Job { get; set; }
    public string FilePath { get; set; }
  }
}
