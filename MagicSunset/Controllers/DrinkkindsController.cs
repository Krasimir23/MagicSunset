using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagicSunset.Data;

namespace MagicSunset.Controllers
{
    public class DrinkkindsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DrinkkindsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Drinkkinds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Drinkkind.ToListAsync());
        }

        // GET: Drinkkinds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkkind = await _context.Drinkkind
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkkind == null)
            {
                return NotFound();
            }

            return View(drinkkind);
        }

        // GET: Drinkkinds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Drinkkinds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DrinkKind")] Drinkkind drinkkind)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drinkkind);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drinkkind);
        }

        // GET: Drinkkinds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkkind = await _context.Drinkkind.FindAsync(id);
            if (drinkkind == null)
            {
                return NotFound();
            }
            return View(drinkkind);
        }

        // POST: Drinkkinds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DrinkKind")] Drinkkind drinkkind)
        {
            if (id != drinkkind.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drinkkind);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkkindExists(drinkkind.Id))
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
            return View(drinkkind);
        }

        // GET: Drinkkinds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkkind = await _context.Drinkkind
                .FirstOrDefaultAsync(m => m.Id == id);
            if (drinkkind == null)
            {
                return NotFound();
            }

            return View(drinkkind);
        }

        // POST: Drinkkinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drinkkind = await _context.Drinkkind.FindAsync(id);
            _context.Drinkkind.Remove(drinkkind);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkkindExists(int id)
        {
            return _context.Drinkkind.Any(e => e.Id == id);
        }
    }
}
