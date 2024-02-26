using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Data;
using ProjetoFinal.Models;

namespace ProjetoFinal.Controllers
{
    public class CasasController : Controller
    {
        private readonly ProjetoFinalContext _context;

        public CasasController(ProjetoFinalContext context)
        {
            _context = context;
        }

        // GET: Casas
        public async Task<IActionResult> Index()
        {
              return _context.Casa != null ? 
                          View(await _context.Casa.ToListAsync()) :
                          Problem("Entity set 'ProjetoFinalContext.Casa'  is null.");
        }

        // GET: Casas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // GET: Casas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Casas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Zona,N_Assoalhadas,Ano,Preco,Id_Cliente")] Casa casa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(casa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(casa);
        }

        // GET: Casas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa.FindAsync(id);
            if (casa == null)
            {
                return NotFound();
            }
            return View(casa);
        }

        // POST: Casas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Zona,N_Assoalhadas,Ano,Preco,Id_Cliente")] Casa casa)
        {
            if (id != casa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(casa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CasaExists(casa.Id))
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
            return View(casa);
        }

        // GET: Casas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Casa == null)
            {
                return NotFound();
            }

            var casa = await _context.Casa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (casa == null)
            {
                return NotFound();
            }

            return View(casa);
        }

        // POST: Casas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Casa == null)
            {
                return Problem("Entity set 'ProjetoFinalContext.Casa'  is null.");
            }
            var casa = await _context.Casa.FindAsync(id);
            if (casa != null)
            {
                _context.Casa.Remove(casa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CasaExists(int id)
        {
          return (_context.Casa?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
