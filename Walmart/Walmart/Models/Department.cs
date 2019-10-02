using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Walmart.Models
{       
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Esse campo só aceita no máximo 20 caracteres"), MinLength(3, ErrorMessage = "O minímo aceito são 3 caracteres")]
        public string Name { get; set; }

        [Url]
        public string Site { get; set; }

        [Display(Name = "Costumer Satisfaction")]
        [Range(1,5)]
        public int? CostumerSatisfaction { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name, string site, int? costumerSatisfaction)
        {
            Id = id;
            Name = name;
            Site = site;
            CostumerSatisfaction = costumerSatisfaction;
        }

        public void AddSeller(Seller Seller)
        {
            Sellers.Add(Seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // Vamos usar o LINQ

            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
