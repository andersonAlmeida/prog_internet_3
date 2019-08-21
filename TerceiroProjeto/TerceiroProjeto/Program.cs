using System; // import da biblioteca de implementações básicas

namespace TerceiroProjeto // pacotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // capturando dados do teclado
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();
            string[] nomeCompleto = nome.Split(" ");
            
            Console.WriteLine("Seu nome é: " + nomeCompleto[0] + " " + nomeCompleto[1]);


            // conversão de tipo
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());


            // condicional if else
            if( idade >= 18 )
            {
                Console.WriteLine("Pode ter CNH");
            } else
            {
                Console.WriteLine("Não pode ter CNH");
            }

            // Condicional else if
            if( idade <= 12 )
            {
                Console.WriteLine("Você é uma criança");
            } else if( idade <= 21 )
            {
                Console.WriteLine("Você é um adolescente");
            } else if (idade <= 60)
            {
                Console.WriteLine("Você é um adulto");
            } else
            {
                Console.WriteLine("Você é um idoso");
            }
        }
    }
}
