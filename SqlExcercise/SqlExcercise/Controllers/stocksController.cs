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
    public class stocksController : Controller
    {
        private readonly SqlExcerciseContext _context;

        public stocksController(SqlExcerciseContext context)
        {
            _context = context;
        }

        // GET: stocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.stocks.ToListAsync());
        }

        // GET: stocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stocks = await _context.stocks
                .FirstOrDefaultAsync(m => m.Store_Id == id);
            if (stocks == null)
            {
                return NotFound();
            }

            return View(stocks);
        }

        // GET: stocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: stocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Store_Id,Product_Id,Quantity")] stocks stocks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stocks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stocks);
        }

        // GET: stocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stocks = await _context.stocks.FindAsync(id);
            if (stocks == null)
            {
                return NotFound();
            }
            return View(stocks);
        }

        // POST: stocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Store_Id,Product_Id,Quantity")] stocks stocks)
        {
            if (id != stocks.Store_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stocks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!stocksExists(stocks.Store_Id))
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
            return View(stocks);
        }

        // GET: stocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stocks = await _context.stocks
                .FirstOrDefaultAsync(m => m.Store_Id == id);
            if (stocks == null)
            {
                return NotFound();
            }

            return View(stocks);
        }

        // POST: stocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stocks = await _context.stocks.FindAsync(id);
            _context.stocks.Remove(stocks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool stocksExists(int id)
        {
            return _context.stocks.Any(e => e.Store_Id == id);
        }
    }
}
