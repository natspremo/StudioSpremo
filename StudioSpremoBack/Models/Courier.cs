using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudioSpremoBack.Models
{
    public class Courier
    {
        [Key]
        public string Id { get; set; }
        public string CourierName { get; set; }
        public int DeliveryTrackingNum { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string RecipientName { get; set; }
        public string AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }


    }
}
