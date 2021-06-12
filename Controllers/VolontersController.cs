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
    public class VolontersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VolontersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Volonters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Volonter.ToListAsync());
        }

        // GET: Volonters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volonter = await _context.Volonter
                .FirstOrDefaultAsync(m => m.id == id);
            if (volonter == null)
            {
                return NotFound();
            }

            return View(volonter);
        }

        // GET: Volonters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Volonters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Volonter volonter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(volonter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(volonter);
        }

        // GET: Volonters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volonter = await _context.Volonter.FindAsync(id);
            if (volonter == null)
            {
                return NotFound();
            }
            return View(volonter);
        }

        // POST: Volonters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Volonter volonter)
        {
            if (id != volonter.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(volonter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VolonterExists(volonter.id))
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
            return View(volonter);
        }

        // GET: Volonters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var volonter = await _context.Volonter
                .FirstOrDefaultAsync(m => m.id == id);
            if (volonter == null)
            {
                return NotFound();
            }

            return View(volonter);
        }

        // POST: Volonters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var volonter = await _context.Volonter.FindAsync(id);
            _context.Volonter.Remove(volonter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VolonterExists(int id)
        {
            return _context.Volonter.Any(e => e.id == id);
        }
    }
}
