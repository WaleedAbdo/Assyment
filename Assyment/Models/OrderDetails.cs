using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assyment.Models
{
    public class OrderDetails
    {
        public  int  OrderDetailsid { get; set; }
        public DateTime DateTime { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
