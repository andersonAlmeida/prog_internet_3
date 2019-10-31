using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal.Models
{
    public class ProjetoFinal0Context : DbContext
    {
        public ProjetoFinal0Context (DbContextOptions<ProjetoFinal0Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoFinal.Models.Administrador> Administrador { get; set; }
    }
}
