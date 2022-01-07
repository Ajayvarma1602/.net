﻿using System;
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
    public class staffsController : Controller
    {
        private readonly SqlExcerciseContext _context;

        public staffsController(SqlExcerciseContext context)
        {
            _context = context;
        }

        // GET: staffs
        public async Task<IActionResult> Index()
        {
            var sqlExcerciseContext = _context.staffs.Include(s => s.store);
            return View(await sqlExcerciseContext.ToListAsync());
        }

        // GET: staffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffs = await _context.staffs
                .Include(s => s.store)
                .FirstOrDefaultAsync(m => m.Staff_Id == id);
            if (staffs == null)
            {
                return NotFound();
            }

            return View(staffs);
        }

        // GET: staffs/Create
        public IActionResult Create()
        {
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email");
            return View();
        }

        // POST: staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Staff_Id,Frist_Name,Last_Name,Email,Phone,Active,Store_Id,Manager_Id")] staffs staffs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staffs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", staffs.Store_Id);
            return View(staffs);
        }

        // GET: staffs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffs = await _context.staffs.FindAsync(id);
            if (staffs == null)
            {
                return NotFound();
            }
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", staffs.Store_Id);
            return View(staffs);
        }

        // POST: staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Staff_Id,Frist_Name,Last_Name,Email,Phone,Active,Store_Id,Manager_Id")] staffs staffs)
        {
            if (id != staffs.Staff_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staffs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!staffsExists(staffs.Staff_Id))
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
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", staffs.Store_Id);
            return View(staffs);
        }

        // GET: staffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staffs = await _context.staffs
                .Include(s => s.store)
                .FirstOrDefaultAsync(m => m.Staff_Id == id);
            if (staffs == null)
            {
                return NotFound();
            }

            return View(staffs);
        }

        // POST: staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staffs = await _context.staffs.FindAsync(id);
            _context.staffs.Remove(staffs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool staffsExists(int id)
        {
            return _context.staffs.Any(e => e.Staff_Id == id);
        }
    }
}
