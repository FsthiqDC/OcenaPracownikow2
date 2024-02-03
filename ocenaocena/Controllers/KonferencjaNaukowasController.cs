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
    public class KonferencjaNaukowasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KonferencjaNaukowasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: KonferencjaNaukowas
        public async Task<IActionResult> Index()
        {
              return _context.CzynnyUdzialWKonferencjach != null ? 
                          View(await _context.CzynnyUdzialWKonferencjach.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CzynnyUdzialWKonferencjach'  is null.");
        }

        // GET: KonferencjaNaukowas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CzynnyUdzialWKonferencjach == null)
            {
                return NotFound();
            }

            var konferencjaNaukowa = await _context.CzynnyUdzialWKonferencjach
                .FirstOrDefaultAsync(m => m.KonferencjaNaukowaId == id);
            if (konferencjaNaukowa == null)
            {
                return NotFound();
            }

            return View(konferencjaNaukowa);
        }

        // GET: KonferencjaNaukowas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KonferencjaNaukowas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KonferencjaNaukowaId,Rola,ZasiegKonferencji,TytulReferatu,NazwaKonferencji,DataKonferencji,MiejsceKonferencji,NazwaOrganizatoraKonferencji")] KonferencjaNaukowa konferencjaNaukowa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(konferencjaNaukowa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(konferencjaNaukowa);
        }

        // GET: KonferencjaNaukowas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CzynnyUdzialWKonferencjach == null)
            {
                return NotFound();
            }

            var konferencjaNaukowa = await _context.CzynnyUdzialWKonferencjach.FindAsync(id);
            if (konferencjaNaukowa == null)
            {
                return NotFound();
            }
            return View(konferencjaNaukowa);
        }

        // POST: KonferencjaNaukowas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KonferencjaNaukowaId,Rola,ZasiegKonferencji,TytulReferatu,NazwaKonferencji,DataKonferencji,MiejsceKonferencji,NazwaOrganizatoraKonferencji")] KonferencjaNaukowa konferencjaNaukowa)
        {
            if (id != konferencjaNaukowa.KonferencjaNaukowaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(konferencjaNaukowa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KonferencjaNaukowaExists(konferencjaNaukowa.KonferencjaNaukowaId))
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
            return View(konferencjaNaukowa);
        }

        // GET: KonferencjaNaukowas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CzynnyUdzialWKonferencjach == null)
            {
                return NotFound();
            }

            var konferencjaNaukowa = await _context.CzynnyUdzialWKonferencjach
                .FirstOrDefaultAsync(m => m.KonferencjaNaukowaId == id);
            if (konferencjaNaukowa == null)
            {
                return NotFound();
            }

            return View(konferencjaNaukowa);
        }

        // POST: KonferencjaNaukowas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CzynnyUdzialWKonferencjach == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CzynnyUdzialWKonferencjach'  is null.");
            }
            var konferencjaNaukowa = await _context.CzynnyUdzialWKonferencjach.FindAsync(id);
            if (konferencjaNaukowa != null)
            {
                _context.CzynnyUdzialWKonferencjach.Remove(konferencjaNaukowa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KonferencjaNaukowaExists(int id)
        {
          return (_context.CzynnyUdzialWKonferencjach?.Any(e => e.KonferencjaNaukowaId == id)).GetValueOrDefault();
        }
    }
}
