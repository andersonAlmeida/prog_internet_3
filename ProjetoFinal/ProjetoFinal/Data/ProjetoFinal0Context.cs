using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Models
{
    public class ProjetoFinal0Context : DbContext
    {
        public ProjetoFinal0Context (DbContextOptions<ProjetoFinal0Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoFinal.Models.Administrador> Administrador { get; set; }

        public DbSet<ProjetoFinal.Models.Categoria> Categoria { get; set; }

        public DbSet<ProjetoFinal.Models.Marca> Marca { get; set; }

        public DbSet<ProjetoFinal.Models.Pedido> Pedido { get; set; }

        public DbSet<ProjetoFinal.Models.Produto> Produto { get; set; }

        public DbSet<ProjetoFinal.Models.ProdutoPedido> ProdutoPedido { get; set; }
    }
}
