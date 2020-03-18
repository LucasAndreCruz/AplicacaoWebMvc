using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicacaoWebMvc.Data;
using AplicacaoWebMvc.Models;

namespace AplicacaoWebMvc.Controllers
{
    public class FichariosController : Controller
    {
        private readonly AplicacaoWebMvcContext _context;

        public FichariosController(AplicacaoWebMvcContext context)
        {
            _context = context;
        }

        // GET: Ficharios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fichario.ToListAsync());
        }

        // GET: Ficharios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fichario = await _context.Fichario
                .FirstOrDefaultAsync(m => m.FicharioId == id);
            if (fichario == null)
            {
                return NotFound();
            }

            return View(fichario);
        }

        // GET: Ficharios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ficharios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FicharioId,Nome")] Fichario fichario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fichario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fichario);
        }

        // GET: Ficharios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fichario = await _context.Fichario.FindAsync(id);
            if (fichario == null)
            {
                return NotFound();
            }
            return View(fichario);
        }

        // POST: Ficharios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FicharioId,Nome")] Fichario fichario)
        {
            if (id != fichario.FicharioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fichario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FicharioExists(fichario.FicharioId))
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
            return View(fichario);
        }

        // GET: Ficharios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fichario = await _context.Fichario
                .FirstOrDefaultAsync(m => m.FicharioId == id);
            if (fichario == null)
            {
                return NotFound();
            }

            return View(fichario);
        }

        // POST: Ficharios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fichario = await _context.Fichario.FindAsync(id);
            _context.Fichario.Remove(fichario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FicharioExists(int id)
        {
            return _context.Fichario.Any(e => e.FicharioId == id);
        }
    }
}
