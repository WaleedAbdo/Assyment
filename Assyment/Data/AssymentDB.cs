using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assyment.Models;

namespace Assyment.Data
{
    public class AssymentDB : DbContext
    {
        public AssymentDB (DbContextOptions<AssymentDB> options)
            : base(options)
        {
        }

        public DbSet<Assyment.Models.Customer> Customer { get; set; }

        public DbSet<Assyment.Models.Product> Product { get; set; }

        public DbSet<Assyment.Models.OrderDetails> OrderDetails { get; set; }
    }
}
