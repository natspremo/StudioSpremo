using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class AddressModel
    {
        public string Id { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public int PostalCode { get; set; }
        public string Street { get; set; }
    }
}
