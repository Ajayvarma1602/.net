using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SqlExcercise.Data;
using SqlExcercise.Models;

namespace SqlExcercise.Controllers
{
    public class storesController : Controller
    {
        private readonly SqlExcerciseContext _context;

        public storesController(SqlExcerciseContext context)
        {
            _context = context;
        }

        // GET: stores
        public async Task<IActionResult> Index()
        {
            return View(await _context.stores.ToListAsync());
        }

        // GET: stores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores
                .FirstOrDefaultAsync(m => m.Store_Id == id);
            if (stores == null)
            {
                return NotFound();
            }

            return View(stores);
        }

        // GET: stores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: stores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Store_Id,Store_Name,Phone,Email,Street,City,State,Zipcode")] stores stores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stores);
        }

        // GET: stores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores.FindAsync(id);
            if (stores == null)
            {
                return NotFound();
            }
            return View(stores);
        }

        // POST: stores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Store_Id,Store_Name,Phone,Email,Street,City,State,Zipcode")] stores stores)
        {
            if (id != stores.Store_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!storesExists(stores.Store_Id))
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
            return View(stores);
        }

        // GET: stores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stores = await _context.stores
                .FirstOrDefaultAsync(m => m.Store_Id == id);
            if (stores == null)
            {
                return NotFound();
            }

            return View(stores);
        }

        // POST: stores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stores = await _context.stores.FindAsync(id);
            _context.stores.Remove(stores);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool storesExists(int id)
        {
            return _context.stores.Any(e => e.Store_Id == id);
        }
    }
}
