using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Walmart.Data;
using Walmart.Models;

namespace Walmart.Services
{
    public class SellerService
    {
        // Declara um objeto que é o contexto do banco
        private readonly WalmartContext _context;

        public SellerService(WalmartContext contex)
        {
            _context = contex;
        }

        public List<Seller> FindAll()
        {
            /* Acessa a tabela Seller e transforma os registros em objetos
             * e retorna como uma lista da objetos */
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            // Retorna o vendedor com o ID passado por parâmetro
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            // Cria uma instância de Seller para apontar para o registro
            // que quero remover
            var seller = _context.Seller.Find(id);

            // Remove o objeto do banco de dados
            _context.Remove(seller);

            // Confirmar transação de exclusão do registro ao
            // EntityFramework para persistir a alteração
            _context.SaveChanges();
        }
    }
}
