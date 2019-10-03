using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Walmart.Models;

namespace Walmart.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            ICollection<Seller> Sellers = new List<Seller>();
            Sellers.Add(new Seller(1, "Anderson", "anderson@senac.com.br", new DateTime(2000, 5, 25), 8789.6, new Department()));
            Sellers.Add(new Seller(1, "Liege", "liege@senac.com.br", new DateTime(2000, 5, 25), 8789.6, new Department()));
            return View(Sellers);
        }
    }
}