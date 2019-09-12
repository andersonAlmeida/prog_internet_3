using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace primeiro_projeto_pi3.Models
{
    public class Department
    {
        [Display(Name = "Code")] // cria um label para acessar o atributo na view
        public int IdDepartment { get; set; }
        public string Name { get; set; }
    }
}
