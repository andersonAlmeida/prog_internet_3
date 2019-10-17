using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Walmart.Models;

namespace Walmart.Data
{
    public class SeedingService
    {

        private WalmartContext _context;

        public SeedingService(WalmartContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //testar se já existe algum dado na minha base de dados
            //Operação ANY do LINQ neste caso vai verificar se há algum registro nesta tabela.
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //Banco de dados já foi criado. Então cancela essa operação!
            }

            //Cria registros de departamentos
            Department d1 = new Department("Computers", "https://github.com/romuloreis/PI3/blob/master/seedingservice.md", 50);
            Department d2 = new Department("Garden", "https://github.com/romuloreis/PI3/blob/master/seedingservice.md", 50);
            Department d3 = new Department("Office", "https://github.com/romuloreis/PI3/blob/master/seedingservice.md", 50);
            Department d4 = new Department("Bedroom", "https://github.com/romuloreis/PI3/blob/master/seedingservice.md", 50);
            Department d5 = new Department { Name = "Living", Site = "https://github.com/romuloreis/PI3/blob/master/seedingservice.md", CostumerSatisfaction = 50};

            //Cria registros de vendedores
            Seller s1 = new Seller("Tinky Winky", "tinkywinky@uaumart.com", new DateTime(1989, 5, 20), 1999.0, d1);
            Seller s2 = new Seller("Dipsy the Green", "dipsy@uaumart.com", new DateTime(1989, 10, 31), 3500.0, d2);
            Seller s3 = new Seller("Laa-Laa", "laalaa@uaumart.com", new DateTime(1988, 10, 31), 23350.0, d1);
            Seller s4 = new Seller("Xuxa Meneguel", "rainha@uaumart.com", new DateTime(1999, 1, 20), 3500.0, d4);
            Seller s5 = new Seller("Po the Red", "po@uaumart.com", new DateTime(2000, 3, 19), 4500.0, d3);
            Seller s6 = new Seller("Power Ranger Amarelo", "poweryellow@uaumart.com",new DateTime(1977, 5, 24), 15900.0, d2);

            //Cria registros de vendas
            SalesRecord r1 = new SalesRecord(new DateTime(2018, 09, 25), 11000.0, SaleStatus.BILLED, s1);
            SalesRecord r2 = new SalesRecord(new DateTime(2018, 09, 4), 7000.0, SaleStatus.BILLED, s5);
            SalesRecord r3 = new SalesRecord(new DateTime(2018, 09, 13), 4000.0, SaleStatus.CANCELED, s4);
            SalesRecord r4 = new SalesRecord(new DateTime(2018, 09, 1), 8000.0, SaleStatus.BILLED, s1);
            SalesRecord r5 = new SalesRecord(new DateTime(2018, 09, 21), 3000.0, SaleStatus.BILLED, s3);
            SalesRecord r6 = new SalesRecord(new DateTime(2018, 09, 15), 2000.0, SaleStatus.BILLED, s1);
            SalesRecord r7 = new SalesRecord(new DateTime(2018, 09, 28), 13000.0, SaleStatus.BILLED, s2);
            SalesRecord r8 = new SalesRecord(new DateTime(2018, 09, 11), 4000.0, SaleStatus.BILLED, s4);
            SalesRecord r9 = new SalesRecord(new DateTime(2018, 09, 14), 11000.0, SaleStatus.PENDING, s6);
            SalesRecord r10 = new SalesRecord(new DateTime(2018, 09, 7), 9000.0, SaleStatus.BILLED, s6);
            SalesRecord r11 = new SalesRecord(new DateTime(2018, 09, 13), 6000.0, SaleStatus.BILLED, s2);
            SalesRecord r12 = new SalesRecord(new DateTime(2018, 09, 25), 7000.0, SaleStatus.PENDING, s3);
            SalesRecord r13 = new SalesRecord(new DateTime(2018, 09, 29), 10000.0, SaleStatus.BILLED, s4);
            SalesRecord r14 = new SalesRecord(new DateTime(2018, 09, 4), 3000.0, SaleStatus.BILLED, s5);
            SalesRecord r15 = new SalesRecord(new DateTime(2018, 09, 12), 4000.0, SaleStatus.BILLED, s1);
            SalesRecord r16 = new SalesRecord(new DateTime(2018, 10, 5), 2000.0, SaleStatus.BILLED, s4);
            SalesRecord r17 = new SalesRecord(new DateTime(2018, 10, 1), 12000.0, SaleStatus.BILLED, s1);
            SalesRecord r18 = new SalesRecord(new DateTime(2018, 10, 24), 6000.0, SaleStatus.BILLED, s3);
            SalesRecord r19 = new SalesRecord(new DateTime(2018, 10, 22), 8000.0, SaleStatus.BILLED, s5);
            SalesRecord r20 = new SalesRecord(new DateTime(2018, 10, 15), 8000.0, SaleStatus.BILLED, s6);
            SalesRecord r21 = new SalesRecord(new DateTime(2018, 10, 17), 9000.0, SaleStatus.BILLED, s2);
            SalesRecord r22 = new SalesRecord(new DateTime(2018, 10, 24), 4000.0, SaleStatus.BILLED, s4);
            SalesRecord r23 = new SalesRecord(new DateTime(2018, 10, 19), 11000.0, SaleStatus.CANCELED, s2);
            SalesRecord r24 = new SalesRecord(new DateTime(2018, 10, 12), 8000.0, SaleStatus.BILLED, s5);
            SalesRecord r25 = new SalesRecord(new DateTime(2018, 10, 31), 7000.0, SaleStatus.BILLED, s3);
            SalesRecord r26 = new SalesRecord(new DateTime(2018, 10, 6), 5000.0, SaleStatus.BILLED, s4);
            SalesRecord r27 = new SalesRecord(new DateTime(2018, 10, 13), 9000.0, SaleStatus.PENDING, s1);
            SalesRecord r28 = new SalesRecord(new DateTime(2018, 10, 7), 4000.0, SaleStatus.BILLED, s3);
            SalesRecord r29 = new SalesRecord(new DateTime(2018, 10, 23), 12000.0, SaleStatus.BILLED, s5);
            SalesRecord r30 = new SalesRecord(new DateTime(2018, 10, 12), 5000.0, SaleStatus.BILLED, s2);

            /*Uma vez que nossos objetos estão criados, basta adicionar eles no banco de dados, usando o EntityFramework*/
            //AddRange permite adicionar um conjunto de objetos. Em outras palavras, vários objetos.
            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                          r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                          r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                          r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                      );
            //Método que efetiva o registro/gravação no banco de dados
            _context.SaveChanges();

        }
    }
}
