using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assyment.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
         [Required]
        public string  CustomerName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        
    }
}
