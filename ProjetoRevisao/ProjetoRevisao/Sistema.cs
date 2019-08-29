using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRevisao
{
    static class Sistema
    {
        public static double CalcularAumento( Assalariado obj, double txAumento )
        {            
            return obj.GetSalario() * txAumento;
        }
    }
}
