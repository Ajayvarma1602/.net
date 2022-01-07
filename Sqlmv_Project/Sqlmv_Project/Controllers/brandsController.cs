﻿using System;
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
    public class brandsController : Controller
    {
        private readonly Sqlmv_ProjectContext _context;

        public brandsController(Sqlmv_ProjectContext context)
        {
            _context = context;
        }

        // GET: brands
        public async Task<IActionResult> Index()
        {
            return View(await _context.brands.ToListAsync());
        }

        // GET: brands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brands = await _context.brands
                .FirstOrDefaultAsync(m => m.Brand_Id == id);
            if (brands == null)
            {
                return NotFound();
            }

            return View(brands);
        }

        // GET: brands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: brands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Brand_Id,Brand_Name")] brands brands)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brands);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brands);
        }

        // GET: brands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brands = await _context.brands.FindAsync(id);
            if (brands == null)
            {
                return NotFound();
            }
            return View(brands);
        }

        // POST: brands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Brand_Id,Brand_Name")] brands brands)
        {
            if (id != brands.Brand_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brands);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!brandsExists(brands.Brand_Id))
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
            return View(brands);
        }

        // GET: brands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brands = await _context.brands
                .FirstOrDefaultAsync(m => m.Brand_Id == id);
            if (brands == null)
            {
                return NotFound();
            }

            return View(brands);
        }

        // POST: brands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brands = await _context.brands.FindAsync(id);
            _context.brands.Remove(brands);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool brandsExists(int id)
        {
            return _context.brands.Any(e => e.Brand_Id == id);
        }
    }
}
