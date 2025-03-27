using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Management_System.Models
{
    public class ProductAttribute
    {
        [Key]
        public int AttributeId { get; set; }

        [Required]
        public string AttributeName { get; set; } // e.g., "WeightPerBag", "Voltage"

        [Required]
        public string AttributeValue { get; set; } // e.g., "50kg", "220V"

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
