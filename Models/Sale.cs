using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_Management_System.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalAmount { get; set; }

        // Navigation property for items in the sale
        public List<SaleDetail> SaleDetails { get; set; } = new();
    }
}
