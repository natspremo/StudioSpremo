﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class PlateDimension
    {
        [Key]
        public string Id { get; set; }
        public double Dimension { get; set; }
    }
}
