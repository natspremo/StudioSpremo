﻿using Microsoft.AspNetCore.Identity;
using StudioSpremoBack.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public ERole Role { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}