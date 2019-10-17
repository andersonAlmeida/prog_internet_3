using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Walmart.Models.ViewModels
{
    public class SellerFormViewModel
    {
        // essa classe tem todos os dados necessários para cadastrar um vendedor
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
