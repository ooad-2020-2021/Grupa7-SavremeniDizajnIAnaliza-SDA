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
    public class ZahtjevZaBankusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZahtjevZaBankusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ZahtjevZaBankus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZahtjevZaBanku.ToListAsync());
        }

        // GET: ZahtjevZaBankus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaBanku = await _context.ZahtjevZaBanku
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaBanku == null)
            {
                return NotFound();
            }

            return View(zahtjevZaBanku);
        }

        // GET: ZahtjevZaBankus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZahtjevZaBankus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] ZahtjevZaBanku zahtjevZaBanku)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zahtjevZaBanku);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zahtjevZaBanku);
        }

        // GET: ZahtjevZaBankus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaBanku = await _context.ZahtjevZaBanku.FindAsync(id);
            if (zahtjevZaBanku == null)
            {
                return NotFound();
            }
            return View(zahtjevZaBanku);
        }

        // POST: ZahtjevZaBankus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] ZahtjevZaBanku zahtjevZaBanku)
        {
            if (id != zahtjevZaBanku.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjevZaBanku);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevZaBankuExists(zahtjevZaBanku.id))
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
            return View(zahtjevZaBanku);
        }

        // GET: ZahtjevZaBankus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjevZaBanku = await _context.ZahtjevZaBanku
                .FirstOrDefaultAsync(m => m.id == id);
            if (zahtjevZaBanku == null)
            {
                return NotFound();
            }

            return View(zahtjevZaBanku);
        }

        // POST: ZahtjevZaBankus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjevZaBanku = await _context.ZahtjevZaBanku.FindAsync(id);
            _context.ZahtjevZaBanku.Remove(zahtjevZaBanku);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevZaBankuExists(int id)
        {
            return _context.ZahtjevZaBanku.Any(e => e.id == id);
        }
    }
}
