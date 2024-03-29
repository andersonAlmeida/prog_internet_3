﻿using System;
using System.Collections.Generic;

namespace QuintoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atribui uma instância do objeto Cliente à variável clienteA
            Cliente clienteA = new Cliente();

            clienteA.Nome = "Anderson";
            clienteA.Salario = 27000.88;

            // Criando uma conta para o clienteA
            Conta contaA = new Conta();

            // atribuido valores aos atributos da conta
            contaA.titular = clienteA;            
            contaA.agencia = 0001;
            contaA.conta = 1234;

            //Cria ClienteB
            Cliente clienteB = new Cliente("Liege", "Almeida", 15000.50);

            Conta contaB = new Conta()
            {
                titular = clienteB,
                agencia = 0001,
                conta = 1235                
            };

            /* ClienteC
             * Utilizando construtor Initializar / Inicializador 
             */
            Cliente clienteC = new Cliente() {
                Nome = "Valentin",
                Salario = 9780.36
            };

            Conta contaC = new Conta()
            {
                titular = clienteC,
                agencia = 0001,
                conta = 1236
            };

            ClienteFisico cf = new ClienteFisico("01236547898", "508080820", 27387.47)
            {
                Nome = "Anderson"
            };
            //cf.Cpf = "01236547898";
            Console.Write( cf.GetInfo() );

            //ClienteJuridico cj = new ClienteJuridico();

            //Lista de clientes
            List<Cliente> lista = new List<Cliente>();
            lista.Add(cf);
            lista.Add(new ClienteFisico("78943213545", "63021548", 987.00) {
                Nome = "Jorge"
            });

            //for(int i=0; i<lista.Count; i++)
            //{
            //    Console.WriteLine( lista[i].Nome );
            //}

            foreach( Cliente c in lista )
            {
                Console.WriteLine(c.Nome);
            }







            //contaA.Depositar(500.98);
            //contaA.Depositar(1500.98);
            //contaA.Depositar(4500.80);
            //contaA.Depositar(72000.63);

            /*
            // Escreve os dados do cliente
            Console.WriteLine("O cliente {0} tem um salário de R${1}", clienteA.Nome, clienteA.Salario );

            // Escreve os dados da conta
            Console.WriteLine( "Titular: {0} \nR${1}", contaA.titular.Nome, contaA.GetSaldo() );

            // ClienteA tenta sacar $$$
            if(contaA.Sacar(1000.00))
            {
                Console.WriteLine("Você sacou da sua conta. Seu saldo atual é de R${0}.", contaA.GetSaldo());
            } else
            {
                Console.WriteLine( "Seu saldo é de R${0} e é insuficiente para sacar o valor solicitado.", contaA.GetSaldo() );
            }
            */
        }
    }
}
