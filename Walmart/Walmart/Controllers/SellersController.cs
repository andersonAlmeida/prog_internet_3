using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Walmart.Models;
using Walmart.Models.ViewModels;
using Walmart.Services;

namespace Walmart.Controllers
{
    public class SellersController : Controller
    {
        // injeção de dependência do serviço de acesso aos dados de vendedores
        // e também de departamentos
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        // construtor para finalizar a injeção de dependência
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();            
            return View(list);
        }

        public IActionResult Create()
        {
            // Carrega os departamentos, utilizando o serviço de acesso aos dados
            // de departamentos

            var departments = _departmentService.FindAll(); // acessa um serviço que tem acesso ao banco de dados

            //Instanciar um objeto ViewModel de SellerFormViewModel, que vai conter propriedades, a primeira é o
            // lista de departamentos e a outra será Seller.

            var viewModel = new SellerFormViewModel
            {
                Departments = departments
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(SellerFormViewModel obj)
        {
            Seller slr = obj.Seller;
            _sellerService.Insert(slr);
            return RedirectToAction("Index");
        }

        /* Para tornar um parâmetro opcional basta 
         * adicionar um simbolo ? após o tipo da variável */
        public IActionResult Delete(int? id)
        {
            // verifica se o usuário acessou a url sem passar um id
            if (id == null)
            {
                return NotFound();
            }

            // Tenta buscar o registro desse vendedor
            var obj = _sellerService.FindById(id.Value);

            // Verifico se o id era válido, ou seja
            // se havia um vendedor com esse id
            if (obj == null)
            {
                // Vendedor não encontrado, retorna a página de não encontrado
                return NotFound();
            }

            // Retorna o vendedor para o delete.cshtml
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}