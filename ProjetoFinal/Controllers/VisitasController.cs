﻿using System;
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
    public class VisitasController : Controller
    {
        private readonly ProjetoFinalContext _context;

        public VisitasController(ProjetoFinalContext context)
        {
            _context = context;
        }

        // GET: Visitas
        public async Task<IActionResult> Index()
        {
              return _context.Visita != null ? 
                          View(await _context.Visita.ToListAsync()) :
                          Problem("Entity set 'ProjetoFinalContext.Visita'  is null.");
        }

        // GET: Visitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Visita == null)
            {
                return NotFound();
            }

            var visita = await _context.Visita
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visita == null)
            {
                return NotFound();
            }

            return View(visita);
        }

        // GET: Visitas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_Cliente,ID_Casa")] Visita visita)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visita);
        }

        // GET: Visitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Visita == null)
            {
                return NotFound();
            }

            var visita = await _context.Visita.FindAsync(id);
            if (visita == null)
            {
                return NotFound();
            }
            return View(visita);
        }

        // POST: Visitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_Cliente,ID_Casa")] Visita visita)
        {
            if (id != visita.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitaExists(visita.Id))
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
            return View(visita);
        }

        // GET: Visitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Visita == null)
            {
                return NotFound();
            }

            var visita = await _context.Visita
                .FirstOrDefaultAsync(m => m.Id == id);
            if (visita == null)
            {
                return NotFound();
            }

            return View(visita);
        }

        // POST: Visitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Visita == null)
            {
                return Problem("Entity set 'ProjetoFinalContext.Visita'  is null.");
            }
            var visita = await _context.Visita.FindAsync(id);
            if (visita != null)
            {
                _context.Visita.Remove(visita);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitaExists(int id)
        {
          return (_context.Visita?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
