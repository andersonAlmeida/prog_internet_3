using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Walmart.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [MaxLength(20, ErrorMessage = "O limite máximo é 20 caracteres")]
        [MinLength(2, ErrorMessage = "O limite minímo é 2 caracteres")]
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }

        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            SalesRecords.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            SalesRecords.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return 0;
        }
    }
}
