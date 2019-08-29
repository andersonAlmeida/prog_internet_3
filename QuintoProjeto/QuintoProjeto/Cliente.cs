using System;
using System.Collections.Generic;
using System.Text;

namespace QuintoProjeto
{
    abstract class Cliente
    {
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

        /* A palavra VIRTUAL indica que é permitido 
         * sobreescrever esse método
         */
        public virtual string GetInfo()
        {
            return Nome;
        }

    }
}
