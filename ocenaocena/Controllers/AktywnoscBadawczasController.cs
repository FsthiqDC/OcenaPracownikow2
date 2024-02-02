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
    public class AktywnoscBadawczasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AktywnoscBadawczasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AktywnoscBadawczas
        public async Task<IActionResult> Index()
        {
              return _context.AktywnoscBadawcza != null ? 
                          View(await _context.AktywnoscBadawcza.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.AktywnoscBadawcza'  is null.");
        }

        // GET: AktywnoscBadawczas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AktywnoscBadawcza == null)
            {
                return NotFound();
            }

            var aktywnoscBadawcza = await _context.AktywnoscBadawcza
                .FirstOrDefaultAsync(m => m.AktywnoscBadawczaId == id);
            if (aktywnoscBadawcza == null)
            {
                return NotFound();
            }

            return View(aktywnoscBadawcza);
        }

        // GET: AktywnoscBadawczas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AktywnoscBadawczas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AktywnoscBadawczaId,TytulProjektu,ProjektWspolrealizowany,ZasiegProjektu,NazwaLideraProjektu,FunkcjaWProjekcie,InstytucjaFinansujacaProjekt,NazwaKonkursu,DataZawarciaUmowy,DataZlozeniaWniosku,DataRozpoczeciaProjektu,DataZakonczeniaProjektu,UserId")] AktywnoscBadawcza aktywnoscBadawcza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aktywnoscBadawcza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aktywnoscBadawcza);
        }

        // GET: AktywnoscBadawczas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AktywnoscBadawcza == null)
            {
                return NotFound();
            }

            var aktywnoscBadawcza = await _context.AktywnoscBadawcza.FindAsync(id);
            if (aktywnoscBadawcza == null)
            {
                return NotFound();
            }
            return View(aktywnoscBadawcza);
        }

        // POST: AktywnoscBadawczas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AktywnoscBadawczaId,TytulProjektu,ProjektWspolrealizowany,ZasiegProjektu,NazwaLideraProjektu,FunkcjaWProjekcie,InstytucjaFinansujacaProjekt,NazwaKonkursu,DataZawarciaUmowy,DataZlozeniaWniosku,DataRozpoczeciaProjektu,DataZakonczeniaProjektu,UserId")] AktywnoscBadawcza aktywnoscBadawcza)
        {
            if (id != aktywnoscBadawcza.AktywnoscBadawczaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aktywnoscBadawcza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AktywnoscBadawczaExists(aktywnoscBadawcza.AktywnoscBadawczaId))
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
            return View(aktywnoscBadawcza);
        }

        // GET: AktywnoscBadawczas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AktywnoscBadawcza == null)
            {
                return NotFound();
            }

            var aktywnoscBadawcza = await _context.AktywnoscBadawcza
                .FirstOrDefaultAsync(m => m.AktywnoscBadawczaId == id);
            if (aktywnoscBadawcza == null)
            {
                return NotFound();
            }

            return View(aktywnoscBadawcza);
        }

        // POST: AktywnoscBadawczas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AktywnoscBadawcza == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AktywnoscBadawcza'  is null.");
            }
            var aktywnoscBadawcza = await _context.AktywnoscBadawcza.FindAsync(id);
            if (aktywnoscBadawcza != null)
            {
                _context.AktywnoscBadawcza.Remove(aktywnoscBadawcza);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AktywnoscBadawczaExists(int id)
        {
          return (_context.AktywnoscBadawcza?.Any(e => e.AktywnoscBadawczaId == id)).GetValueOrDefault();
        }
    }
}
