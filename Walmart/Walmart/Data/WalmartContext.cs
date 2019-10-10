using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Walmart.Data
{
    public class WalmartContext : DbContext
    {
        public WalmartContext (DbContextOptions<WalmartContext> options)
            : base(options)
        {
        }

        public DbSet<Walmart.Models.Department> Department { get; set; }
        public DbSet<Walmart.Models.Seller> Seller { get; set; }
        public DbSet<Walmart.Models.SalesRecord> SalesRecord { get; set; }
        
    }
}

// Ferramentas > Gerenciador de Pacotes do Nuget > Console
// Add-Migration [NomeDaMigracao]
// Depois do Migration atualizar o banco
// Update-Database