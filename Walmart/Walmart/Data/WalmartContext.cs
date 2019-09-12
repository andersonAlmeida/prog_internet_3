using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Walmart.Models
{
    public class WalmartContext : DbContext
    {
        public WalmartContext (DbContextOptions<WalmartContext> options)
            : base(options)
        {
        }

        public DbSet<Walmart.Models.Department> Department { get; set; }
    }
}
