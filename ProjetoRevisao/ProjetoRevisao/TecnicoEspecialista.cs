using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRevisao
{
    class TecnicoEspecialista : Tecnico
    {
        public string Especialidade { get; set; }

        public TecnicoEspecialista( string especialidade,
            string nome, int idade,
            string funcao, double salario):base(nome, idade, funcao, salario)  {

            this.Especialidade = especialidade;
        }

        /* Pode sobrescrever sem o método MostrarDados
         * da classe Tecnico ter a palavra "virtual"
         * pois a característica "virtual" foi herdada de Pessoa */

        /* A palavra "sealed" indica que o método foi selado e não pode ser mais sobrescrito
         * pelos herdeiros da classe TecnicoEspecialista */
        public sealed override void MostrarDados()
        {
            base.MostrarDados();

            Console.WriteLine("Especialidade: " + this.Especialidade);
        }
    }
}
