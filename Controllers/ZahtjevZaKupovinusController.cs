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
    public class ZahtjevZaKupovinusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZahtjevZaKupovinusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ZahtjevZaKupovinus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZahtjevZaKupovinu.ToListAsync());
        }

        // GET: ZahtjevZaKupovinus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaKupovinu = await _context.ZahtjevZaKupovinu
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaKupovinu == null)
            {
                return NotFound();
            }

            return View(zahtjevZaKupovinu);
        }

        // GET: ZahtjevZaKupovinus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZahtjevZaKupovinus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] ZahtjevZaKupovinu zahtjevZaKupovinu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaKupovinu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaKupovinu);
        }

        // GET: ZahtjevZaKupovinus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaKupovinu = await _context.ZahtjevZaKupovinu.FindAsync(id);
            if (zahtjevZaKupovinu == null)
            {
                return NotFound();
            }
            return View(zahtjevZaKupovinu);
        }

        // POST: ZahtjevZaKupovinus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] ZahtjevZaKupovinu zahtjevZaKupovinu)
        {
            if (id != zahtjevZaKupovinu.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjevZaKupovinu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaKupovinuExists(zahtjevZaKupovinu.id))
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
            return View(zahtjevZaKupovinu);
        }

        // GET: ZahtjevZaKupovinus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaKupovinu = await _context.ZahtjevZaKupovinu
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaKupovinu == null)
            {
                return NotFound();
            }

            return View(zahtjevZaKupovinu);
        }

        // POST: ZahtjevZaKupovinus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjevZaKupovinu = await _context.ZahtjevZaKupovinu.FindAsync(id);
            _context.ZahtjevZaKupovinu.Remove(zahtjevZaKupovinu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevZaKupovinuExists(int id)
        {
            return _context.ZahtjevZaKupovinu.Any(e => e.id == id);
        }
    }
}
