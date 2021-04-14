using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class Address
    {
        [Key]
        public string Id { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public int PostalCode { get; set; }
        public string Street { get; set; }
    }
}
