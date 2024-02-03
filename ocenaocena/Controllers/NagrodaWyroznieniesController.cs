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
    public class NagrodaWyroznieniesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NagrodaWyroznieniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NagrodaWyroznienies
        public async Task<IActionResult> Index()
        {
              return _context.NagrodyWyroznienia != null ? 
                          View(await _context.NagrodyWyroznienia.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NagrodyWyroznienia'  is null.");
        }

        // GET: NagrodaWyroznienies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NagrodyWyroznienia == null)
            {
                return NotFound();
            }

            var nagrodaWyroznienie = await _context.NagrodyWyroznienia
                .FirstOrDefaultAsync(m => m.NagrodaWyroznienieId == id);
            if (nagrodaWyroznienie == null)
            {
                return NotFound();
            }

            return View(nagrodaWyroznienie);
        }

        // GET: NagrodaWyroznienies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NagrodaWyroznienies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NagrodaWyroznienieId,NagrodaMinistraNazwa,NagrodaMinistraTerminOtrzymania,NagrodaRektoraNazwa,NagrodaRektoraTerminOtrzymania,NagrodaOrganizacjiNazwa,NagrodaOrganizacjiTerminOtrzymania")] NagrodaWyroznienie nagrodaWyroznienie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nagrodaWyroznienie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nagrodaWyroznienie);
        }

        // GET: NagrodaWyroznienies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NagrodyWyroznienia == null)
            {
                return NotFound();
            }

            var nagrodaWyroznienie = await _context.NagrodyWyroznienia.FindAsync(id);
            if (nagrodaWyroznienie == null)
            {
                return NotFound();
            }
            return View(nagrodaWyroznienie);
        }

        // POST: NagrodaWyroznienies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NagrodaWyroznienieId,NagrodaMinistraNazwa,NagrodaMinistraTerminOtrzymania,NagrodaRektoraNazwa,NagrodaRektoraTerminOtrzymania,NagrodaOrganizacjiNazwa,NagrodaOrganizacjiTerminOtrzymania")] NagrodaWyroznienie nagrodaWyroznienie)
        {
            if (id != nagrodaWyroznienie.NagrodaWyroznienieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nagrodaWyroznienie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NagrodaWyroznienieExists(nagrodaWyroznienie.NagrodaWyroznienieId))
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
            return View(nagrodaWyroznienie);
        }

        // GET: NagrodaWyroznienies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NagrodyWyroznienia == null)
            {
                return NotFound();
            }

            var nagrodaWyroznienie = await _context.NagrodyWyroznienia
                .FirstOrDefaultAsync(m => m.NagrodaWyroznienieId == id);
            if (nagrodaWyroznienie == null)
            {
                return NotFound();
            }

            return View(nagrodaWyroznienie);
        }

        // POST: NagrodaWyroznienies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.NagrodyWyroznienia == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NagrodyWyroznienia'  is null.");
            }
            var nagrodaWyroznienie = await _context.NagrodyWyroznienia.FindAsync(id);
            if (nagrodaWyroznienie != null)
            {
                _context.NagrodyWyroznienia.Remove(nagrodaWyroznienie);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NagrodaWyroznienieExists(int id)
        {
          return (_context.NagrodyWyroznienia?.Any(e => e.NagrodaWyroznienieId == id)).GetValueOrDefault();
        }
    }
}
