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
            var filtered_product = products.Where(p => p.Price > 700 && p.Category.Id == 2);

            var r1 = products.Where(p => p.Category.Type == 3 && p.Price < 50);

            Print("Lista de Produtos maiores que $700 e da categoria computers", filtered_product);
            Print("Lista de Produtos menores que $50 e da categoria furnitures", r1);
        }
    }
}
