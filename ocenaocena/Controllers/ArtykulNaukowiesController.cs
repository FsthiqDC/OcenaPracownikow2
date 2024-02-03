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
    public class ArtykulNaukowiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtykulNaukowiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ArtykulNaukowies
        public async Task<IActionResult> Index()
        {
              return _context.ArtykulyNaukowe != null ? 
                          View(await _context.ArtykulyNaukowe.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ArtykulyNaukowe'  is null.");
        }

        // GET: ArtykulNaukowies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ArtykulyNaukowe == null)
            {
                return NotFound();
            }

            var artykulNaukowy = await _context.ArtykulyNaukowe
                .FirstOrDefaultAsync(m => m.ArtykulNaukowyId == id);
            if (artykulNaukowy == null)
            {
                return NotFound();
            }

            return View(artykulNaukowy);
        }

        // GET: ArtykulNaukowies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ArtykulNaukowies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArtykulNaukowyId,Rola,DOI,TytulArtykuluNaukowego,TytulCzasopismaNaukowego,ISSN,RokOpublikowania,TomZeszytCzasopisma,NumeryStron,LiczbaWszystkichAutorow,PozostaliWspolautorzy,DyscyplinaNaukowa,NazwaPodmiotuUpowaznionego,NazwaKonferencji,DataKonferencji,MiejsceKonferencji,SposobUdostepnienia,WersjaTekstuOtwarta,LicencjaOtwarta,DataUdostepnienia,UdostepnienieNastapilo")] ArtykulNaukowy artykulNaukowy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artykulNaukowy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artykulNaukowy);
        }

        // GET: ArtykulNaukowies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ArtykulyNaukowe == null)
            {
                return NotFound();
            }

            var artykulNaukowy = await _context.ArtykulyNaukowe.FindAsync(id);
            if (artykulNaukowy == null)
            {
                return NotFound();
            }
            return View(artykulNaukowy);
        }

        // POST: ArtykulNaukowies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ArtykulNaukowyId,Rola,DOI,TytulArtykuluNaukowego,TytulCzasopismaNaukowego,ISSN,RokOpublikowania,TomZeszytCzasopisma,NumeryStron,LiczbaWszystkichAutorow,PozostaliWspolautorzy,DyscyplinaNaukowa,NazwaPodmiotuUpowaznionego,NazwaKonferencji,DataKonferencji,MiejsceKonferencji,SposobUdostepnienia,WersjaTekstuOtwarta,LicencjaOtwarta,DataUdostepnienia,UdostepnienieNastapilo")] ArtykulNaukowy artykulNaukowy)
        {
            if (id != artykulNaukowy.ArtykulNaukowyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artykulNaukowy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtykulNaukowyExists(artykulNaukowy.ArtykulNaukowyId))
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
            return View(artykulNaukowy);
        }

        // GET: ArtykulNaukowies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ArtykulyNaukowe == null)
            {
                return NotFound();
            }

            var artykulNaukowy = await _context.ArtykulyNaukowe
                .FirstOrDefaultAsync(m => m.ArtykulNaukowyId == id);
            if (artykulNaukowy == null)
            {
                return NotFound();
            }

            return View(artykulNaukowy);
        }

        // POST: ArtykulNaukowies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ArtykulyNaukowe == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ArtykulyNaukowe'  is null.");
            }
            var artykulNaukowy = await _context.ArtykulyNaukowe.FindAsync(id);
            if (artykulNaukowy != null)
            {
                _context.ArtykulyNaukowe.Remove(artykulNaukowy);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtykulNaukowyExists(int id)
        {
          return (_context.ArtykulyNaukowe?.Any(e => e.ArtykulNaukowyId == id)).GetValueOrDefault();
        }
    }
}
