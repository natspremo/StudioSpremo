using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class PolymerThickness
    {
        [Key]
        public string Id { get; set; }
        public double Thickness { get; set; }
    }
}
