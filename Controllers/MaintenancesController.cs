using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using AktifVehiclePlanningSystem.Data;

namespace AktifVehiclePlanningSystem.Controllers
{
    public class MaintenancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaintenancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maintenances
        public async Task<IActionResult> Index()
        {
              return View(await _context.Maintenances.ToListAsync());
        }

        // GET: Maintenances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // GET: Maintenances/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Maintenances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CarId,LastMaintenanceTime,LastMaintenanceMileage,WorkDone,NextMaintenanceTime,NextMaintenanceMileage")] Maintenance maintenance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(maintenance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maintenance);
        }

        // GET: Maintenances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances.FindAsync(id);
            if (maintenance == null)
            {
                return NotFound();
            }
            return View(maintenance);
        }

        // POST: Maintenances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CarId,LastMaintenanceTime,LastMaintenanceMileage,WorkDone,NextMaintenanceTime,NextMaintenanceMileage")] Maintenance maintenance)
        {
            if (id != maintenance.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceExists(maintenance.Id))
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
            return View(maintenance);
        }

        // GET: Maintenances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Maintenances == null)
            {
                return NotFound();
            }

            var maintenance = await _context.Maintenances
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maintenance == null)
            {
                return NotFound();
            }

            return View(maintenance);
        }

        // POST: Maintenances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Maintenances == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Maintenances'  is null.");
            }
            var maintenance = await _context.Maintenances.FindAsync(id);
            if (maintenance != null)
            {
                _context.Maintenances.Remove(maintenance);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceExists(int id)
        {
          return _context.Maintenances.Any(e => e.Id == id);
        }
    }
}
