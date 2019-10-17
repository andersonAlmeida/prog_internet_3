using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Walmart.Data;
using Walmart.Models;

namespace Walmart.Services
{
    public class DepartmentService
    {
        private readonly WalmartContext _context;

        public DepartmentService(WalmartContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            // retorna todos os departamentos ordenados por nome
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
