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
    public class DishkindsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DishkindsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Dishkinds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dishkind.ToListAsync());
        }

        // GET: Dishkinds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishkind = await _context.Dishkind
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dishkind == null)
            {
                return NotFound();
            }

            return View(dishkind);
        }

        // GET: Dishkinds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dishkinds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FoodName")] Dishkind dishkind)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dishkind);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dishkind);
        }

        // GET: Dishkinds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishkind = await _context.Dishkind.FindAsync(id);
            if (dishkind == null)
            {
                return NotFound();
            }
            return View(dishkind);
        }

        // POST: Dishkinds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FoodName")] Dishkind dishkind)
        {
            if (id != dishkind.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dishkind);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DishkindExists(dishkind.Id))
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
            return View(dishkind);
        }

        // GET: Dishkinds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishkind = await _context.Dishkind
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dishkind == null)
            {
                return NotFound();
            }

            return View(dishkind);
        }

        // POST: Dishkinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dishkind = await _context.Dishkind.FindAsync(id);
            _context.Dishkind.Remove(dishkind);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DishkindExists(int id)
        {
            return _context.Dishkind.Any(e => e.Id == id);
        }
    }
}
