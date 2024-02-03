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
    public class EkspertyzaNaukowasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EkspertyzaNaukowasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EkspertyzaNaukowas
        public async Task<IActionResult> Index()
        {
              return _context.RealizacjaZleconychEkspertyz != null ? 
                          View(await _context.RealizacjaZleconychEkspertyz.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.RealizacjaZleconychEkspertyz'  is null.");
        }

        // GET: EkspertyzaNaukowas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RealizacjaZleconychEkspertyz == null)
            {
                return NotFound();
            }

            var ekspertyzaNaukowa = await _context.RealizacjaZleconychEkspertyz
                .FirstOrDefaultAsync(m => m.EkspertyzaNaukowaId == id);
            if (ekspertyzaNaukowa == null)
            {
                return NotFound();
            }

            return View(ekspertyzaNaukowa);
        }

        // GET: EkspertyzaNaukowas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EkspertyzaNaukowas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EkspertyzaNaukowaId,NazwaInstytucjiZlecajacej,TytulEkspertyzyOpracowaniaNaukowego,TerminPrzekazania")] EkspertyzaNaukowa ekspertyzaNaukowa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ekspertyzaNaukowa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ekspertyzaNaukowa);
        }

        // GET: EkspertyzaNaukowas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RealizacjaZleconychEkspertyz == null)
            {
                return NotFound();
            }

            var ekspertyzaNaukowa = await _context.RealizacjaZleconychEkspertyz.FindAsync(id);
            if (ekspertyzaNaukowa == null)
            {
                return NotFound();
            }
            return View(ekspertyzaNaukowa);
        }

        // POST: EkspertyzaNaukowas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EkspertyzaNaukowaId,NazwaInstytucjiZlecajacej,TytulEkspertyzyOpracowaniaNaukowego,TerminPrzekazania")] EkspertyzaNaukowa ekspertyzaNaukowa)
        {
            if (id != ekspertyzaNaukowa.EkspertyzaNaukowaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ekspertyzaNaukowa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EkspertyzaNaukowaExists(ekspertyzaNaukowa.EkspertyzaNaukowaId))
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
            return View(ekspertyzaNaukowa);
        }

        // GET: EkspertyzaNaukowas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RealizacjaZleconychEkspertyz == null)
            {
                return NotFound();
            }

            var ekspertyzaNaukowa = await _context.RealizacjaZleconychEkspertyz
                .FirstOrDefaultAsync(m => m.EkspertyzaNaukowaId == id);
            if (ekspertyzaNaukowa == null)
            {
                return NotFound();
            }

            return View(ekspertyzaNaukowa);
        }

        // POST: EkspertyzaNaukowas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RealizacjaZleconychEkspertyz == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RealizacjaZleconychEkspertyz'  is null.");
            }
            var ekspertyzaNaukowa = await _context.RealizacjaZleconychEkspertyz.FindAsync(id);
            if (ekspertyzaNaukowa != null)
            {
                _context.RealizacjaZleconychEkspertyz.Remove(ekspertyzaNaukowa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EkspertyzaNaukowaExists(int id)
        {
          return (_context.RealizacjaZleconychEkspertyz?.Any(e => e.EkspertyzaNaukowaId == id)).GetValueOrDefault();
        }
    }
}
