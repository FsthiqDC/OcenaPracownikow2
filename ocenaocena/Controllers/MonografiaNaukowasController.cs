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
    public class MonografiaNaukowasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MonografiaNaukowasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MonografiaNaukowas
        public async Task<IActionResult> Index()
        {
              return _context.MonografieNaukowe != null ? 
                          View(await _context.MonografieNaukowe.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.MonografieNaukowe'  is null.");
        }

        // GET: MonografiaNaukowas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MonografieNaukowe == null)
            {
                return NotFound();
            }

            var monografiaNaukowa = await _context.MonografieNaukowe
                .FirstOrDefaultAsync(m => m.MonografiaNaukowaId == id);
            if (monografiaNaukowa == null)
            {
                return NotFound();
            }

            return View(monografiaNaukowa);
        }

        // GET: MonografiaNaukowas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MonografiaNaukowas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MonografiaNaukowaId,TytulProjektu,ProjektRealizowanyJest,ZasiegProjektu,NazwaLideraProjektu,FunkcjaWProjekcie,InstytucjaFinansujacaProjekt,NazwaKonkursuProgramu,DataZawarciaINumerUmowy,DataZlozeniaWniosku,DataRozpoczeciaPracy,DataZakonczeniaPracy,DyscyplinyNaukowe,RolaMonografii,DOI,TytulMonografii,TytulRozdzialuMonografii,ISBN,LiczbaWszystkichAutorowMonografii,PozostaliWspolautorzyIRedaktorzyMonografii,PozostaliWspolautorzyRozdzialu,NumeryORCIDWspolautorowIRedaktorowMonografii,NumeryORCIDWspolautorowRozdzialu,WydawcaMonografii,RokWydaniaMonografii,DyscyplinaNaukowaMonografii,DyscyplinaNaukowaRozdzialuMonografii,NazwaPodmiotuUpowaznionegoMonografia,NazwaPodmiotuUpowaznionegoRozdzial,SposobUdostepnieniaMonografii,WersjaTekstuOtwarta,LicencjaOtwarta,DataUdostepnieniaMonografii,UdostepnienieNastapilo")] MonografiaNaukowa monografiaNaukowa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monografiaNaukowa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monografiaNaukowa);
        }

        // GET: MonografiaNaukowas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MonografieNaukowe == null)
            {
                return NotFound();
            }

            var monografiaNaukowa = await _context.MonografieNaukowe.FindAsync(id);
            if (monografiaNaukowa == null)
            {
                return NotFound();
            }
            return View(monografiaNaukowa);
        }

        // POST: MonografiaNaukowas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MonografiaNaukowaId,TytulProjektu,ProjektRealizowanyJest,ZasiegProjektu,NazwaLideraProjektu,FunkcjaWProjekcie,InstytucjaFinansujacaProjekt,NazwaKonkursuProgramu,DataZawarciaINumerUmowy,DataZlozeniaWniosku,DataRozpoczeciaPracy,DataZakonczeniaPracy,DyscyplinyNaukowe,RolaMonografii,DOI,TytulMonografii,TytulRozdzialuMonografii,ISBN,LiczbaWszystkichAutorowMonografii,PozostaliWspolautorzyIRedaktorzyMonografii,PozostaliWspolautorzyRozdzialu,NumeryORCIDWspolautorowIRedaktorowMonografii,NumeryORCIDWspolautorowRozdzialu,WydawcaMonografii,RokWydaniaMonografii,DyscyplinaNaukowaMonografii,DyscyplinaNaukowaRozdzialuMonografii,NazwaPodmiotuUpowaznionegoMonografia,NazwaPodmiotuUpowaznionegoRozdzial,SposobUdostepnieniaMonografii,WersjaTekstuOtwarta,LicencjaOtwarta,DataUdostepnieniaMonografii,UdostepnienieNastapilo")] MonografiaNaukowa monografiaNaukowa)
        {
            if (id != monografiaNaukowa.MonografiaNaukowaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monografiaNaukowa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonografiaNaukowaExists(monografiaNaukowa.MonografiaNaukowaId))
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
            return View(monografiaNaukowa);
        }

        // GET: MonografiaNaukowas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MonografieNaukowe == null)
            {
                return NotFound();
            }

            var monografiaNaukowa = await _context.MonografieNaukowe
                .FirstOrDefaultAsync(m => m.MonografiaNaukowaId == id);
            if (monografiaNaukowa == null)
            {
                return NotFound();
            }

            return View(monografiaNaukowa);
        }

        // POST: MonografiaNaukowas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MonografieNaukowe == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MonografieNaukowe'  is null.");
            }
            var monografiaNaukowa = await _context.MonografieNaukowe.FindAsync(id);
            if (monografiaNaukowa != null)
            {
                _context.MonografieNaukowe.Remove(monografiaNaukowa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonografiaNaukowaExists(int id)
        {
          return (_context.MonografieNaukowe?.Any(e => e.MonografiaNaukowaId == id)).GetValueOrDefault();
        }
    }
}
