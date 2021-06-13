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
    public class ZalbasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZalbasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Zalbas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zalba.ToListAsync());
        }

        // GET: Zalbas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zalba = await _context.Zalba
                .FirstOrDefaultAsync(m => m.id == id);
            if (zalba == null)
            {
                return NotFound();
            }

            return View(zalba);
        }

        // GET: Zalbas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zalbas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Zalba zalba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zalba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zalba);
        }

        // GET: Zalbas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zalba = await _context.Zalba.FindAsync(id);
            if (zalba == null)
            {
                return NotFound();
            }
            return View(zalba);
        }

        // POST: Zalbas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Zalba zalba)
        {
            if (id != zalba.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zalba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZalbaExists(zalba.id))
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
            return View(zalba);
        }

        // GET: Zalbas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zalba = await _context.Zalba
                .FirstOrDefaultAsync(m => m.id == id);
            if (zalba == null)
            {
                return NotFound();
            }

            return View(zalba);
        }

        // POST: Zalbas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zalba = await _context.Zalba.FindAsync(id);
            _context.Zalba.Remove(zalba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZalbaExists(int id)
        {
            return _context.Zalba.Any(e => e.id == id);
        }
    }
}
