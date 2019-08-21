using System;

namespace QuartoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, senha;

            /*Executa o bloco e verifica se a condição é verdadeira
             para continuar ou falsa para parar e sair do laço
             */
            do
            {
                Console.WriteLine("Informe seu login:");
                login = Console.ReadLine();
            } while (login.Length <= 3);

            senha = "errada";

            /*
             Começa a executar somente se a condição é verdadeira
             e após a execução verifica a condição novamente
             */
            while( senha.Equals( "errada" ) )
            {
                Console.WriteLine("Informe sua senha:");
                senha = Console.ReadLine();
            }            

            // Comparação de Strings
            // String.Equals(str1, str2) - Retorna true ou false
            if( String.Equals(login, "admin") )
            {
                Console.WriteLine("Bem-vindo " + login);
            }
            // String.Compare( str1, str2 ) - Retorna: 0, > 0 ou < 0
            else if ( String.Compare(login, "user") == 0 )
            {
                Console.WriteLine("Bem-vindo " + login);
            }
            

            // Exemplo de sintaxe de laço de repetição 
            // for( iniciacao; condicao; incremento )
            for( int i=0; i <= 10; i++ )
            {
                Console.Write(i + " ");
            }
        }
    }
}
