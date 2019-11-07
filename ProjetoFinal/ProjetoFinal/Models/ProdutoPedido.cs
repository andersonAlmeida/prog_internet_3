using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class ProdutoPedido
    {
        [Key]
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
