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
    public class DzialalnoscOrganizacyjnasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DzialalnoscOrganizacyjnasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DzialalnoscOrganizacyjnas
        public async Task<IActionResult> Index()
        {
              return _context.DzialalnoscWOrganizacjachNaukowych != null ? 
                          View(await _context.DzialalnoscWOrganizacjachNaukowych.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.DzialalnoscWOrganizacjachNaukowych'  is null.");
        }

        // GET: DzialalnoscOrganizacyjnas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DzialalnoscWOrganizacjachNaukowych == null)
            {
                return NotFound();
            }

            var dzialalnoscOrganizacyjna = await _context.DzialalnoscWOrganizacjachNaukowych
                .FirstOrDefaultAsync(m => m.DzialalnoscOrganizacyjnaId == id);
            if (dzialalnoscOrganizacyjna == null)
            {
                return NotFound();
            }

            return View(dzialalnoscOrganizacyjna);
        }

        // GET: DzialalnoscOrganizacyjnas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DzialalnoscOrganizacyjnas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DzialalnoscOrganizacyjnaId,Rola,ZasiegOrganizacji,NazwaOrganizacji,TerminPrzynaleznosci")] DzialalnoscOrganizacyjna dzialalnoscOrganizacyjna)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dzialalnoscOrganizacyjna);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dzialalnoscOrganizacyjna);
        }

        // GET: DzialalnoscOrganizacyjnas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DzialalnoscWOrganizacjachNaukowych == null)
            {
                return NotFound();
            }

            var dzialalnoscOrganizacyjna = await _context.DzialalnoscWOrganizacjachNaukowych.FindAsync(id);
            if (dzialalnoscOrganizacyjna == null)
            {
                return NotFound();
            }
            return View(dzialalnoscOrganizacyjna);
        }

        // POST: DzialalnoscOrganizacyjnas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DzialalnoscOrganizacyjnaId,Rola,ZasiegOrganizacji,NazwaOrganizacji,TerminPrzynaleznosci")] DzialalnoscOrganizacyjna dzialalnoscOrganizacyjna)
        {
            if (id != dzialalnoscOrganizacyjna.DzialalnoscOrganizacyjnaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dzialalnoscOrganizacyjna);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DzialalnoscOrganizacyjnaExists(dzialalnoscOrganizacyjna.DzialalnoscOrganizacyjnaId))
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
            return View(dzialalnoscOrganizacyjna);
        }

        // GET: DzialalnoscOrganizacyjnas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DzialalnoscWOrganizacjachNaukowych == null)
            {
                return NotFound();
            }

            var dzialalnoscOrganizacyjna = await _context.DzialalnoscWOrganizacjachNaukowych
                .FirstOrDefaultAsync(m => m.DzialalnoscOrganizacyjnaId == id);
            if (dzialalnoscOrganizacyjna == null)
            {
                return NotFound();
            }

            return View(dzialalnoscOrganizacyjna);
        }

        // POST: DzialalnoscOrganizacyjnas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DzialalnoscWOrganizacjachNaukowych == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DzialalnoscWOrganizacjachNaukowych'  is null.");
            }
            var dzialalnoscOrganizacyjna = await _context.DzialalnoscWOrganizacjachNaukowych.FindAsync(id);
            if (dzialalnoscOrganizacyjna != null)
            {
                _context.DzialalnoscWOrganizacjachNaukowych.Remove(dzialalnoscOrganizacyjna);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DzialalnoscOrganizacyjnaExists(int id)
        {
          return (_context.DzialalnoscWOrganizacjachNaukowych?.Any(e => e.DzialalnoscOrganizacyjnaId == id)).GetValueOrDefault();
        }
    }
}
