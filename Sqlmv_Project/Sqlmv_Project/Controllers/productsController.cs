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
    public class productsController : Controller
    {
        private readonly Sqlmv_ProjectContext _context;

        public productsController(Sqlmv_ProjectContext context)
        {
            _context = context;
        }

        // GET: products
        public async Task<IActionResult> Index()
        {
            return View(await _context.products.ToListAsync());
        }

        // GET: products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.products
                .FirstOrDefaultAsync(m => m.Product_Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Product_Id,Product_Name,Brand_Id,Category_Id,Model_Year,List_Price")] products products)
        {
            if (ModelState.IsValid)
            {
                _context.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        // GET: products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }

        // POST: products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Product_Id,Product_Name,Brand_Id,Category_Id,Model_Year,List_Price")] products products)
        {
            if (id != products.Product_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!productsExists(products.Product_Id))
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
            return View(products);
        }

        // GET: products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.products
                .FirstOrDefaultAsync(m => m.Product_Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.products.FindAsync(id);
            _context.products.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool productsExists(int id)
        {
            return _context.products.Any(e => e.Product_Id == id);
        }
    }
}
