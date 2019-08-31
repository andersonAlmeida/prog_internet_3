using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whatsapp
{
    abstract class Mensagem
    {
        private Contatinho destinatario;
        private string horaEnvio;
        private string conteudo;

        public void toString() { }
    }
}
