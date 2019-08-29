using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRevisao
{
    /* Classe abstrata não pode ser instanciada mas pode implementar métodos */
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        /* Virtual indica que meus herdeiros podem modificar esse método */
        public virtual void MostrarDados() {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }

        /* método abstrato - Obriga meus herdeiros 
         * à implementar esse método */
        public abstract void Cumprimentar();
    }
}
