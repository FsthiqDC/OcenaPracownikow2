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
    public class PozostalaDzialalnoscNaukowasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PozostalaDzialalnoscNaukowasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PozostalaDzialalnoscNaukowas
        public async Task<IActionResult> Index()
        {
              return _context.PozostaleDzialalnosciNaukowe != null ? 
                          View(await _context.PozostaleDzialalnosciNaukowe.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PozostaleDzialalnosciNaukowe'  is null.");
        }

        // GET: PozostalaDzialalnoscNaukowas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PozostaleDzialalnosciNaukowe == null)
            {
                return NotFound();
            }

            var pozostalaDzialalnoscNaukowa = await _context.PozostaleDzialalnosciNaukowe
                .FirstOrDefaultAsync(m => m.PozostalaDzialalnoscNaukowaId == id);
            if (pozostalaDzialalnoscNaukowa == null)
            {
                return NotFound();
            }

            return View(pozostalaDzialalnoscNaukowa);
        }

        // GET: PozostalaDzialalnoscNaukowas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PozostalaDzialalnoscNaukowas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PozostalaDzialalnoscNaukowaId,Rola,NazwaOrganizacji,TerminDzialalnosciOd,TerminDzialalnosciDo")] PozostalaDzialalnoscNaukowa pozostalaDzialalnoscNaukowa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pozostalaDzialalnoscNaukowa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pozostalaDzialalnoscNaukowa);
        }

        // GET: PozostalaDzialalnoscNaukowas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PozostaleDzialalnosciNaukowe == null)
            {
                return NotFound();
            }

            var pozostalaDzialalnoscNaukowa = await _context.PozostaleDzialalnosciNaukowe.FindAsync(id);
            if (pozostalaDzialalnoscNaukowa == null)
            {
                return NotFound();
            }
            return View(pozostalaDzialalnoscNaukowa);
        }

        // POST: PozostalaDzialalnoscNaukowas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PozostalaDzialalnoscNaukowaId,Rola,NazwaOrganizacji,TerminDzialalnosciOd,TerminDzialalnosciDo")] PozostalaDzialalnoscNaukowa pozostalaDzialalnoscNaukowa)
        {
            if (id != pozostalaDzialalnoscNaukowa.PozostalaDzialalnoscNaukowaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pozostalaDzialalnoscNaukowa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PozostalaDzialalnoscNaukowaExists(pozostalaDzialalnoscNaukowa.PozostalaDzialalnoscNaukowaId))
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
            return View(pozostalaDzialalnoscNaukowa);
        }

        // GET: PozostalaDzialalnoscNaukowas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PozostaleDzialalnosciNaukowe == null)
            {
                return NotFound();
            }

            var pozostalaDzialalnoscNaukowa = await _context.PozostaleDzialalnosciNaukowe
                .FirstOrDefaultAsync(m => m.PozostalaDzialalnoscNaukowaId == id);
            if (pozostalaDzialalnoscNaukowa == null)
            {
                return NotFound();
            }

            return View(pozostalaDzialalnoscNaukowa);
        }

        // POST: PozostalaDzialalnoscNaukowas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PozostaleDzialalnosciNaukowe == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PozostaleDzialalnosciNaukowe'  is null.");
            }
            var pozostalaDzialalnoscNaukowa = await _context.PozostaleDzialalnosciNaukowe.FindAsync(id);
            if (pozostalaDzialalnoscNaukowa != null)
            {
                _context.PozostaleDzialalnosciNaukowe.Remove(pozostalaDzialalnoscNaukowa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PozostalaDzialalnoscNaukowaExists(int id)
        {
          return (_context.PozostaleDzialalnosciNaukowe?.Any(e => e.PozostalaDzialalnoscNaukowaId == id)).GetValueOrDefault();
        }
    }
}
