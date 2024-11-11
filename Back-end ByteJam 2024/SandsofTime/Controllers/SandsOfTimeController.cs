using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SandsofTime.Data;
using SandsofTime.Models;

namespace SandsofTime.Controllers
{
    public class SandsOfTimeController : Controller
    {
        private readonly SandsofTimeContext _context;

        public SandsOfTimeController(SandsofTimeContext context)
        {
            _context = context;
        }

        // GET: SandsOfTime
        public async Task<IActionResult> Index()
        {
            return View(await _context.SandsOfTime.ToListAsync());
            // return View();
        }


        public async Task<IActionResult> Name()
        {
            return View();
        }

        public async Task<IActionResult> Options()
        {
            return View();
        }
        

        // GET: SandsOfTime/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sandsOfTime = await _context.SandsOfTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sandsOfTime == null)
            {
                return NotFound();
            }

            return View(sandsOfTime);
        }

        // GET: SandsOfTime/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SandsOfTime/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,playerName")] SandsOfTime sandsOfTime)
        {
            if (ModelState.IsValid)
            {
                sandsOfTime.Id = Guid.NewGuid();
                _context.Add(sandsOfTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sandsOfTime);
        }

        // GET: SandsOfTime/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sandsOfTime = await _context.SandsOfTime.FindAsync(id);
            if (sandsOfTime == null)
            {
                return NotFound();
            }
            return View(sandsOfTime);
        }

        // POST: SandsOfTime/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,playerName")] SandsOfTime sandsOfTime)
        {
            if (id != sandsOfTime.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sandsOfTime);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SandsOfTimeExists(sandsOfTime.Id))
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
            return View(sandsOfTime);
        }

        // GET: SandsOfTime/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sandsOfTime = await _context.SandsOfTime
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sandsOfTime == null)
            {
                return NotFound();
            }

            return View(sandsOfTime);
        }

        // POST: SandsOfTime/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sandsOfTime = await _context.SandsOfTime.FindAsync(id);
            if (sandsOfTime != null)
            {
                _context.SandsOfTime.Remove(sandsOfTime);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SandsOfTimeExists(Guid id)
        {
            return _context.SandsOfTime.Any(e => e.Id == id);
        }
    }
}
