using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Balloonproject.Models;
using Balloonproject.Migrations;

namespace Balloonproject.Controllers
{
    public class BalloonsController : Controller
    {
        private readonly BalloonprojectContext _context;

        public BalloonsController(BalloonprojectContext context)
        {
            _context = context;
        }

        // GET: Balloons
        public async Task<IActionResult> Index()
        {
              return _context.Balloon != null ? 
                          View(await _context.Balloon.ToListAsync()) :
                          Problem("Entity set 'BalloonprojectContext.Balloon'  is null.");
        }

        // GET: Balloons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Balloon == null)
            {
                return NotFound();
            }

            var balloon = await _context.Balloon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (balloon == null)
            {
                return NotFound();
            }

            return View(balloon);
        }


        // GET: Balloons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Balloons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Create([Bind("Id,Name,Material,Shape,Size,Color,Price,ImageUrl")] Balloon balloon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(balloon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(balloon);
        }

        // GET: Balloons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Balloon == null)
            {
                return NotFound();
            }

            var balloon = await _context.Balloon.FindAsync(id);
            if (balloon == null)
            {
                return NotFound();
            }
            return View(balloon);
        }

        // POST: Balloons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Material, Shape, Size, Color, Price, ImageUrl")] Balloon Balloon)
        {
            if (id != Balloon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Balloon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {

                    if (!BalloonExists(Balloon.Id))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(Balloon);
        }

        private bool BalloonExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: Balloons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Balloon == null)
            {
                return NotFound();
            }

            var Balloon = await _context.Balloon
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Balloon == null)
            {
                return NotFound();
            }

            return View(Balloon);
        }

        // POST: Balloons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Balloon == null)
            {
                return Problem("Entity set 'Balloonproject.Balloon'  is null.");
            }
            var Balloon = await _context.Balloon.FindAsync(id);
            if (Balloon != null)
            {
                _context.Balloon.Remove(Balloon);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Balloon(int id) => (_context.Balloon?.Any(e => e.Id == id)).GetValueOrDefault();
    }
}
