using ProjetoLinq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoLinq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> list)
        {
            Console.WriteLine(message);

            foreach (T item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n");
{}
        }

        static void Main(string[] args)
        {
            // criar categorias
            Category c1 = new Category() {
                Id = 1,
                Name = "Eletronics",
                Type = 1
            };

            Category c2 = new Category()
            {
                Id = 2,
                Name = "Computers",
                Type = 2
            };

            Category c3 = new Category()
            {
                Id = 3,
                Name = "Furnitures",
                Type = 3
            };

            // criar lista de produtos
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Price = 500.0, Name = "Smartphone", Category = c1 },
                new Product() { Id = 2, Price = 1200.0, Name = "Laptop", Category = c2 },
                new Product() { Id = 3, Price = 1200.0, Name = "Diner Room", Category = c3 },
                new Product() { Id = 4, Price = 3000.8, Name = "Macbook Pro", Category = c2 },
                new Product() { Id = 5, Price = 20.0, Name = "Chair", Category = c3 },
                new Product() { Id = 6, Price = 750.5, Name = "Smart Tv", Category = c1 }
            };

            // filtra e armazena o resultado do filtro em uma variavel genérica
            var r1 = products.Where(p => p.Price > 700 && p.Category.Id == 2);
            Print("Lista de Produtos maiores que $700 e da categoria computers", r1);

            var r2 = products.Where(p => p.Category.Type == 3 && p.Price < 50);
            Print("Lista de Produtos menores que $50 e da categoria furnitures", r2);

            var r3 = products.Where(p => p.Category.Name == "Computers").Select(p => p.Name);
            Print("Produtos da Categoria Computers", r3);

            // utilização de objetos anônimos - Objeto de uma classe 
            // Note que CategoryName é um alias para p.Category.Name
            var r4 = products.Where(p => p.Name[0] == 'S').Select(p => new { p.Name, CategpryName = p.Category.Name, p.Price });
            Print("Produtos que começam com a letra S", r4);

            var r5 = products.Where(p => p.Category.Id == 1 ).OrderByDescending(p => p.Price);
            Print("Pega os produtos ordenador por preço", r5);

            var r6 = products.Where(p => p.Category.Id == 2).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Pega os produtos ordenador por preço e nome", r6);

            var r7 = products.FirstOrDefault();
            Console.WriteLine("Primeiro produto da lista \n" + r7 + "\n\n");

            var r8 = products.Where(p => p.Id == 1).SingleOrDefault();
            Console.WriteLine("Produto de Id == 1 \n" + r8);

        }
    }
}
