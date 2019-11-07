using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class ProdutosPedidosController : Controller
    {
        private readonly ProjetoFinal0Context _context;

        public ProdutosPedidosController(ProjetoFinal0Context context)
        {
            _context = context;
        }

        // GET: ProdutosPedidos
        public async Task<IActionResult> Index()
        {
            var projetoFinal0Context = _context.ProdutoPedido.Include(p => p.Pedido).Include(p => p.Produto);
            return View(await projetoFinal0Context.ToListAsync());
        }

        // GET: ProdutosPedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido
                .Include(p => p.Pedido)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Create
        public IActionResult Create()
        {
            ViewData["PedidoId"] = new SelectList(_context.Pedido, "Id", "Id");
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id");
            return View();
        }

        // POST: ProdutosPedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdutoId,PedidoId")] ProdutoPedido produtoPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtoPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PedidoId"] = new SelectList(_context.Pedido, "Id", "Id", produtoPedido.PedidoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", produtoPedido.ProdutoId);
            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido.FindAsync(id);
            if (produtoPedido == null)
            {
                return NotFound();
            }
            ViewData["PedidoId"] = new SelectList(_context.Pedido, "Id", "Id", produtoPedido.PedidoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", produtoPedido.ProdutoId);
            return View(produtoPedido);
        }

        // POST: ProdutosPedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProdutoId,PedidoId")] ProdutoPedido produtoPedido)
        {
            if (id != produtoPedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtoPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoPedidoExists(produtoPedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PedidoId"] = new SelectList(_context.Pedido, "Id", "Id", produtoPedido.PedidoId);
            ViewData["ProdutoId"] = new SelectList(_context.Produto, "Id", "Id", produtoPedido.ProdutoId);
            return View(produtoPedido);
        }

        // GET: ProdutosPedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtoPedido = await _context.ProdutoPedido
                .Include(p => p.Pedido)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produtoPedido == null)
            {
                return NotFound();
            }

            return View(produtoPedido);
        }

        // POST: ProdutosPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produtoPedido = await _context.ProdutoPedido.FindAsync(id);
            _context.ProdutoPedido.Remove(produtoPedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoPedidoExists(int id)
        {
            return _context.ProdutoPedido.Any(e => e.Id == id);
        }
    }
}
