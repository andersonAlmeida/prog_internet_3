using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoMundial
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pessoas Físicas */
            PessoaFisica fisica1 = new PessoaFisica(1, "Rua 1", "51 999887766", "pessoa1@gmail.com", "Jose", "Silva", "5080807875", "01052369877", Convert.ToDateTime("25 / 12 / 1988"));
            PessoaFisica fisica2 = new PessoaFisica(2, "Rua 2", "51 999887766", "pessoa2@gmail.com", "Joao", "Silva", "5080807875", "01052369877", Convert.ToDateTime("10 / 01 / 1978"));
            PessoaFisica fisica3 = new PessoaFisica(3, "Rua 3", "51 999887766", "pessoa3@gmail.com", "Maria", "Silva", "5080807875", "01052369877", Convert.ToDateTime("25 / 10 / 1983"));
            PessoaFisica fisica4 = new PessoaFisica(4, "Rua 4", "51 999887766", "pessoa4@gmail.com", "Bruna", "Silva", "5080807875", "01052369877", Convert.ToDateTime("05 / 02 / 1998"));
            PessoaFisica fisica5 = new PessoaFisica(5, "Rua 5", "51 999887766", "pessoa5@gmail.com", "Ricardo", "Silva", "5080807875", "01052369877", Convert.ToDateTime("01 / 10 / 2001"));

            /* Pessoas Jurídicas */
            ArrayList socios = new ArrayList();
            socios.Add(fisica1);
            socios.Add(fisica2);

            PessoaJuridica empresa1 = new PessoaJuridica(6, "Rua 6", "51 33669988", "empresa1@gmail.com", socios, 1, "Empresa 1", "Senac", 123456, Convert.ToDateTime("08 / 09 / 1995"));

            //Console.WriteLine("Titular: {0} {1}", fisica5.Nome, fisica5.Sobrenome);
            //Console.WriteLine("Idade: {0}", fisica5.GetIdade());
            //Console.WriteLine("Faixa Etaria: {0}", fisica5.GetFaixaEtaria());

            /* Conta salário */
            Conta conta1 = new ContaSalario(fisica1, 12345, 22, 0.0);

            Console.WriteLine("Conta: {0}", conta1.Numero);
            Console.WriteLine("Agencia: {0}", conta1.Agencia);
            Console.WriteLine("Saldo: R$ {0}", conta1.ConsultarSaldo());

            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");

            /* Conta Corrente */
            ContaCorrente conta2 = new ContaCorrente(10000.00, empresa1, 777, 325, 2);

            conta2.Depositar(250000.80);
            conta2.Transferencia(conta1, 2500.00);

            Console.WriteLine("Conta: {0}", conta2.Numero);
            Console.WriteLine("Agencia: {0}", conta2.Agencia);
            Console.WriteLine("Saldo: R$ {0}", conta2.ConsultarSaldo());

            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");

            Console.WriteLine("Conta: {0}", conta1.Numero);
            Console.WriteLine("Agencia: {0}", conta1.Agencia);
            Console.WriteLine("Saldo: R$ {0}", conta1.ConsultarSaldo());



        }
    }
}
