using System;

namespace ProjetoRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Tecnico");
            Tecnico t = new Tecnico("José", 60, "Developer", 36870.56);
            t.MostrarDados();
            t.Cumprimentar();
            Console.WriteLine("Quantidade Técnico: " + Tecnico.Quantidade);
            
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");

            Console.WriteLine("Criando Tecnico Especialista");
            TecnicoEspecialista te = new TecnicoEspecialista("Frontend", "Anderson", 30, "Developer", 4880.88);
            te.MostrarDados();
            Console.WriteLine("Quantidade Técnico: " + Tecnico.Quantidade);

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n");

            Professor p = new Professor();
            Console.WriteLine( Sistema.CalcularAumento(te, 1.1) );
        }
    }
}
