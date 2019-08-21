using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo de variáveis em C# - Igual Java
            bool completo = false;
            char genero = 'F'; // aspas simples
            char letra = '\u0041';
            byte b1 = 123;
            int idade = 79;
            long pontos = 22222L; // se quer explicitar que é long adiciona um L no final
            float salario = 5500.50f; // se quer explicitar que é float adiciona um f no final
            double peso = 85.7; // qualquer número com ponto é assumido como double se não explicitar 
            String nome = "Liege"; // aspas duplas
            Object obj = "Meu Objeto"; // objeto genérico / usar apenas em casos específico
            var saldo = 23.5; // variável genérica / usar apenas em casos específico / optar sempre tipar as variáveis


            Console.WriteLine("completo: " + completo);
            Console.WriteLine("genero: " + genero);
            Console.WriteLine("letra: " + letra);
            Console.WriteLine("b1: " + b1);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("pontos: " + pontos);
            Console.WriteLine("salario: " + salario);
            Console.WriteLine("peso: " + peso);
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("obj: " + obj);
            Console.WriteLine("var: " + saldo);

            float salarioP;
            double salarioG;

            salarioP = 1500.00f;
            salarioG = 7500.80;

            Console.WriteLine("Conversão: " + salarioG);

            salarioP = (float)salarioG;

            Console.WriteLine("Conversão float: " + salarioP);

            int salarioInt;

            salarioInt = (int)salarioP;

            Console.WriteLine("Conversão int: " + salarioInt);

            Console.WriteLine("{0} Recebe R${1}", nome, salarioG);


        }
    }
}
