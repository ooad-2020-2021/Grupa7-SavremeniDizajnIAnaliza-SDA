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
    public class GradjaninsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GradjaninsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gradjanins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gradjanin.ToListAsync());
        }

        // GET: Gradjanins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradjanin = await _context.Gradjanin
                .FirstOrDefaultAsync(m => m.id == id);
            if (gradjanin == null)
            {
                return NotFound();
            }

            return View(gradjanin);
        }

        // GET: Gradjanins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gradjanins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id")] Gradjanin gradjanin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gradjanin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gradjanin);
        }

        // GET: Gradjanins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradjanin = await _context.Gradjanin.FindAsync(id);
            if (gradjanin == null)
            {
                return NotFound();
            }
            return View(gradjanin);
        }

        // POST: Gradjanins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id")] Gradjanin gradjanin)
        {
            if (id != gradjanin.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gradjanin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradjaninExists(gradjanin.id))
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
            return View(gradjanin);
        }

        // GET: Gradjanins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gradjanin = await _context.Gradjanin
                .FirstOrDefaultAsync(m => m.id == id);
            if (gradjanin == null)
            {
                return NotFound();
            }

            return View(gradjanin);
        }

        // POST: Gradjanins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gradjanin = await _context.Gradjanin.FindAsync(id);
            _context.Gradjanin.Remove(gradjanin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradjaninExists(int id)
        {
            return _context.Gradjanin.Any(e => e.id == id);
        }
    }
}
