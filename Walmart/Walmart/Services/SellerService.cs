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
    }
}
