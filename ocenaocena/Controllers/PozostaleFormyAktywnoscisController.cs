using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ocenaocena.Data;
using ocenaocena.Models;

namespace ocenaocena.Controllers
{
    public class PozostaleFormyAktywnoscisController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PozostaleFormyAktywnoscisController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PozostaleFormyAktywnoscis
        public async Task<IActionResult> Index()
        {
              return _context.PozostaleFormyAktywnosci != null ? 
                          View(await _context.PozostaleFormyAktywnosci.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PozostaleFormyAktywnosci'  is null.");
        }

        // GET: PozostaleFormyAktywnoscis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }

            var pozostaleFormyAktywnosci = await _context.PozostaleFormyAktywnosci
                .FirstOrDefaultAsync(m => m.PozostaleFormyAktywnosciId == id);
            if (pozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }

            return View(pozostaleFormyAktywnosci);
        }

        // GET: PozostaleFormyAktywnoscis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PozostaleFormyAktywnoscis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PozostaleFormyAktywnosciId,Opis")] PozostaleFormyAktywnosci pozostaleFormyAktywnosci)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pozostaleFormyAktywnosci);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pozostaleFormyAktywnosci);
        }

        // GET: PozostaleFormyAktywnoscis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }

            var pozostaleFormyAktywnosci = await _context.PozostaleFormyAktywnosci.FindAsync(id);
            if (pozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }
            return View(pozostaleFormyAktywnosci);
        }

        // POST: PozostaleFormyAktywnoscis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PozostaleFormyAktywnosciId,Opis")] PozostaleFormyAktywnosci pozostaleFormyAktywnosci)
        {
            if (id != pozostaleFormyAktywnosci.PozostaleFormyAktywnosciId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pozostaleFormyAktywnosci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PozostaleFormyAktywnosciExists(pozostaleFormyAktywnosci.PozostaleFormyAktywnosciId))
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
            return View(pozostaleFormyAktywnosci);
        }

        // GET: PozostaleFormyAktywnoscis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }

            var pozostaleFormyAktywnosci = await _context.PozostaleFormyAktywnosci
                .FirstOrDefaultAsync(m => m.PozostaleFormyAktywnosciId == id);
            if (pozostaleFormyAktywnosci == null)
            {
                return NotFound();
            }

            return View(pozostaleFormyAktywnosci);
        }

        // POST: PozostaleFormyAktywnoscis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PozostaleFormyAktywnosci == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PozostaleFormyAktywnosci'  is null.");
            }
            var pozostaleFormyAktywnosci = await _context.PozostaleFormyAktywnosci.FindAsync(id);
            if (pozostaleFormyAktywnosci != null)
            {
                _context.PozostaleFormyAktywnosci.Remove(pozostaleFormyAktywnosci);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PozostaleFormyAktywnosciExists(int id)
        {
          return (_context.PozostaleFormyAktywnosci?.Any(e => e.PozostaleFormyAktywnosciId == id)).GetValueOrDefault();
        }
    }
}
