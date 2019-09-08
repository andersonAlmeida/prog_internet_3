using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class Auxiliar
    {
        public int CalculaIdade(DateTime data)
        {
            int idade = 0;
            return idade;
        }

        public string FaixaEtaria(int idade)
        {
            string faixa = "idoso";

            /*
                | Idade    | Categoria  |
                |--------- |----------- |
                | <=11     | criança    |
                | 12 e 21  | jovem      |
                | 22 e 59  | adulto     |
                | >=60     | idoso      | 
            */

            if (idade <= 11)
            {
                faixa = "criança";
            }
            else if (idade <= 21)
            {
                faixa = "joven";
            }
            else if (idade <= 59)
            {
                faixa = "adulto";
            }

            return faixa;
        }
    }
}
