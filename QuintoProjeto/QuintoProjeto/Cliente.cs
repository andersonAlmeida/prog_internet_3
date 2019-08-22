using System;
using System.Collections.Generic;
using System.Text;

namespace QuintoProjeto
{
    abstract class Cliente
    {
        //public string nome;
        //public double salario;

        /* Private, permite acessa à váriavel apenas para o código interno da classe*/
        private string _nome;

        // N maiúsculo porque é uma property
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                /* Ao atribuir um valor à Nome,
                 * é chamado um método set e o valor do parâmetro é atribuído
                 * a variável especial "value"
                 */
                 if( value.Length > 3 )
                    _nome = value;
            }
        }

        // propriedades autoimplementadas
        public double Salario { get; set; }

        // propriedades autoimplementadas onde o set é privado e não pode
        // ser acessado fora da classe
        public string SobreNome { get; private set; }

        //new Cliente()
        public Cliente()
        {
            this.SobreNome = "Silva";
        }

        public Cliente( string nome, double salario )
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public Cliente(string nome, string sobreNome, double salario)
        {
            this.Nome = nome;
            this.SobreNome = sobreNome;
            this.Salario = salario;
        }

        /* A palavra VIRTUAL indica que é permitido 
         * sobreescrever esse método
         */
        public virtual string GetInfo()
        {
            return Nome;
        }

    }
}
