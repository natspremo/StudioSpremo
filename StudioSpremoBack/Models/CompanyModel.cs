using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }         //maticni broj
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public int Contact { get; set; }
        public int PIB { get; set; }
    }
}
