using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagicSunset.Data;
using MagicSunset.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace MagicSunset.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ReservationsController(ApplicationDbContext context, UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Reser.Include(r => r.Tables);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reser
                .Include(r => r.Tables)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // GET: Reservations/Create
        public IActionResult Create()
        {
            ReservationVM model = new ReservationVM();
            model.UserId = _userManager.GetUserId(User);
            model.Tables = _context.Tables.Select(x => new SelectListItem
            {
                Text = x.Descr,
                Value = x.Id.ToString(),
                Selected = x.Id ==  model.TablesId
            }
              ).ToList();
          // ViewData["TablesId"] = new SelectList(_context.Tables, "Id", "Id");
            return View(model);
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Hour,Table,Guests,TablesId,UserId,OrderedOn")] Reservations reservations)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reservations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TablesId"] = new SelectList(_context.Tables, "Id", "Id", reservations.TablesId);
            return View(reservations);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reser.FindAsync(id);
            if (reservations == null)
            {
                return NotFound();
            }
            

            ViewData["TablesId"] = new SelectList(_context.Tables, "Id", "Id", reservations.TablesId);
            return View(reservations);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Hour,Table,Guests,TablesId,UserId,OrderedOn")] Reservations reservations)
        {
            if (id != reservations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationsExists(reservations.Id))
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
            ViewData["TablesId"] = new SelectList(_context.Tables, "Id", "Id", reservations.TablesId);
            return View(reservations);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reser
                .Include(r => r.Tables)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservations = await _context.Reser.FindAsync(id);
            _context.Reser.Remove(reservations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationsExists(int id)
        {
            return _context.Reser.Any(e => e.Id == id);
        }
    }
}
