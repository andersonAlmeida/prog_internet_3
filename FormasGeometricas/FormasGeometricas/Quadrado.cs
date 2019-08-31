using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    class Quadrado : Figura
    {
        private double Lado { get; set; }

        public override double area()
        {
            return this.Lado * this.Lado;
        }
    }
}
