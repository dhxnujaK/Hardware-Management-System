using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Management_System.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; } // Cement, Steel Rods, etc.

        [Required]
        public int QuantityInStock { get; set; }

        [Required]
        public decimal CostPrice { get; set; }

        [Required]
        public decimal SellingPrice { get; set; }

        // Navigation property for category-specific attributes
        public List<ProductAttribute> Attributes { get; set; } = new();
    }
}
