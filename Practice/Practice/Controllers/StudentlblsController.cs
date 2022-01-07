using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice.Data;
using Practice.Models;

namespace Practice.Controllers
{
    public class StudentlblsController : Controller
    {
        private readonly PracticeContext _context;

        public StudentlblsController(PracticeContext context)
        {
            _context = context;
        }

        // GET: Studentlbls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studentlbl.ToListAsync());
        }

        // GET: Studentlbls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentlbl = await _context.Studentlbl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentlbl == null)
            {
                return NotFound();
            }

            return View(studentlbl);
        }

        // GET: Studentlbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studentlbls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RollNumber,Name,Std,AvgMarks")] Studentlbl studentlbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentlbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentlbl);
        }

        // GET: Studentlbls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentlbl = await _context.Studentlbl.FindAsync(id);
            if (studentlbl == null)
            {
                return NotFound();
            }
            return View(studentlbl);
        }

        // POST: Studentlbls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RollNumber,Name,Std,AvgMarks")] Studentlbl studentlbl)
        {
            if (id != studentlbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentlbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentlblExists(studentlbl.Id))
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
            return View(studentlbl);
        }

        // GET: Studentlbls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentlbl = await _context.Studentlbl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentlbl == null)
            {
                return NotFound();
            }

            return View(studentlbl);
        }

        // POST: Studentlbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentlbl = await _context.Studentlbl.FindAsync(id);
            _context.Studentlbl.Remove(studentlbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentlblExists(int id)
        {
            return _context.Studentlbl.Any(e => e.Id == id);
        }
    }
}
