using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;
            double salario;
            char genero;

            Console.WriteLine("Insira o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira a sua idade:");
            idade = int.Parse( Console.ReadLine() );

            Console.WriteLine("Insira o seu salario:");
            salario = double.Parse( Console.ReadLine() );

            Console.WriteLine("Insira o seu genero:");
            genero = char.Parse( Console.ReadLine() );

            Console.WriteLine("{0} tem {1} anos, possui renda de R$ {2} e é do genero {3}", nome, idade, salario, genero);

        }
    }
}
