using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Solidarity.Data;
using Solidarity.Models;

namespace Solidarity.Controllers
{
    public class ZahtjevZaPostusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZahtjevZaPostusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ZahtjevZaPostus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZahtjevZaPostu.ToListAsync());
        }

        // GET: ZahtjevZaPostus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaPostu = await _context.ZahtjevZaPostu
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaPostu == null)
            {
                return NotFound();
            }

            return View(zahtjevZaPostu);
        }

        // GET: ZahtjevZaPostus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZahtjevZaPostus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] ZahtjevZaPostu zahtjevZaPostu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaPostu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaPostu);
        }

        // GET: ZahtjevZaPostus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaPostu = await _context.ZahtjevZaPostu.FindAsync(id);
            if (zahtjevZaPostu == null)
            {
                return NotFound();
            }
            return View(zahtjevZaPostu);
        }

        // POST: ZahtjevZaPostus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] ZahtjevZaPostu zahtjevZaPostu)
        {
            if (id != zahtjevZaPostu.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjevZaPostu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaPostuExists(zahtjevZaPostu.id))
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
            return View(zahtjevZaPostu);
        }

        // GET: ZahtjevZaPostus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaPostu = await _context.ZahtjevZaPostu
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaPostu == null)
            {
                return NotFound();
            }

            return View(zahtjevZaPostu);
        }

        // POST: ZahtjevZaPostus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjevZaPostu = await _context.ZahtjevZaPostu.FindAsync(id);
            _context.ZahtjevZaPostu.Remove(zahtjevZaPostu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevZaPostuExists(int id)
        {
            return _context.ZahtjevZaPostu.Any(e => e.id == id);
        }
    }
}
