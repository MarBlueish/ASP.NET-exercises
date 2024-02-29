using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ativ9_Projeto.Data;
using Ativ9_Projeto.Models;

namespace Ativ9_Projeto.Controllers
{
    public class ViaturasController : Controller
    {
        private readonly Ativ9_ProjetoContext _context;

        public ViaturasController(Ativ9_ProjetoContext context)
        {
            _context = context;
        }

        // GET: Viaturas
        public async Task<IActionResult> Index()
        {
              return _context.Viatura != null ? 
                          View(await _context.Viatura.ToListAsync()) :
                          Problem("Entity set 'Ativ9_ProjetoContext.Viatura'  is null.");
        }

        // GET: Viaturas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Viatura == null)
            {
                return NotFound();
            }

            var viatura = await _context.Viatura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (viatura == null)
            {
                return NotFound();
            }

            return View(viatura);
        }

        // GET: Viaturas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Viaturas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Marca,Modelo,Cor,Cilindrada,Ano,Mes,Tipo,Preco,ForPgto")] Viatura viatura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(viatura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(viatura);
        }

        // GET: Viaturas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Viatura == null)
            {
                return NotFound();
            }

            var viatura = await _context.Viatura.FindAsync(id);
            if (viatura == null)
            {
                return NotFound();
            }
            return View(viatura);
        }

        // POST: Viaturas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Marca,Modelo,Cor,Cilindrada,Ano,Mes,Tipo,Preco,ForPgto")] Viatura viatura)
        {
            if (id != viatura.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viatura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViaturaExists(viatura.ID))
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
            return View(viatura);
        }

        // GET: Viaturas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Viatura == null)
            {
                return NotFound();
            }

            var viatura = await _context.Viatura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (viatura == null)
            {
                return NotFound();
            }

            return View(viatura);
        }

        // POST: Viaturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Viatura == null)
            {
                return Problem("Entity set 'Ativ9_ProjetoContext.Viatura'  is null.");
            }
            var viatura = await _context.Viatura.FindAsync(id);
            if (viatura != null)
            {
                _context.Viatura.Remove(viatura);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViaturaExists(int id)
        {
          return (_context.Viatura?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
