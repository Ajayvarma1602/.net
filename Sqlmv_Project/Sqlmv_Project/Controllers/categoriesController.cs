using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sqlmv_Project.Data;
using Sqlmv_Project.Models;

namespace Sqlmv_Project.Controllers
{
    public class categoriesController : Controller
    {
        private readonly Sqlmv_ProjectContext _context;

        public categoriesController(Sqlmv_ProjectContext context)
        {
            _context = context;
        }

        // GET: categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.categories.ToListAsync());
        }

        // GET: categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.categories
                .FirstOrDefaultAsync(m => m.Category_Id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // GET: categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Category_Id,Category_Name")] categories categories)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categories);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categories);
        }

        // GET: categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.categories.FindAsync(id);
            if (categories == null)
            {
                return NotFound();
            }
            return View(categories);
        }

        // POST: categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Category_Id,Category_Name")] categories categories)
        {
            if (id != categories.Category_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categories);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!categoriesExists(categories.Category_Id))
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
            return View(categories);
        }

        // GET: categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _context.categories
                .FirstOrDefaultAsync(m => m.Category_Id == id);
            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // POST: categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categories = await _context.categories.FindAsync(id);
            _context.categories.Remove(categories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool categoriesExists(int id)
        {
            return _context.categories.Any(e => e.Category_Id == id);
        }
    }
}
