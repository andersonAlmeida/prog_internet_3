using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRevisao
{
    class Professor : Pessoa
    {
        public double Salario { get; set; }
        public string Formacao { get; set; }

        public override void Cumprimentar()
        {
            Console.WriteLine("Bom dia turma!");
        }
    }
}
