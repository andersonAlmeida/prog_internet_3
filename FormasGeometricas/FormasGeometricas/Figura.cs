using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas
{
    abstract class Figura
    {
        private string Cor { get; set; }

        public virtual void area() { }
    }
}
