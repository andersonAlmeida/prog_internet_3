using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Imagem_Thumb { get; set; }
        public string Imagem_Normal { get; set; }
        public int Id_Produto { get; set; }
    }
}
