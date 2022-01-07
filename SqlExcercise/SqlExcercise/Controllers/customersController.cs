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
    public class customersController : Controller
    {
        private readonly SqlExcerciseContext _context;

        public customersController(SqlExcerciseContext context)
        {
            _context = context;
        }

        // GET: customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.customers.ToListAsync());
        }

        // GET: customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.customers
                .FirstOrDefaultAsync(m => m.Customer_Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // GET: customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Customer_Id,Frist_Name,Last_Name,Phone,Email,Street,City,State,Zipcode")] customers customers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customers);
        }

        // GET: customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.customers.FindAsync(id);
            if (customers == null)
            {
                return NotFound();
            }
            return View(customers);
        }

        // POST: customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Customer_Id,Frist_Name,Last_Name,Phone,Email,Street,City,State,Zipcode")] customers customers)
        {
            if (id != customers.Customer_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!customersExists(customers.Customer_Id))
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
            return View(customers);
        }

        // GET: customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customers = await _context.customers
                .FirstOrDefaultAsync(m => m.Customer_Id == id);
            if (customers == null)
            {
                return NotFound();
            }

            return View(customers);
        }

        // POST: customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customers = await _context.customers.FindAsync(id);
            _context.customers.Remove(customers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool customersExists(int id)
        {
            return _context.customers.Any(e => e.Customer_Id == id);
        }
    }
}
