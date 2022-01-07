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
    public class ordersController : Controller
    {
        private readonly SqlExcerciseContext _context;

        public ordersController(SqlExcerciseContext context)
        {
            _context = context;
        }

        // GET: orders
        public async Task<IActionResult> Index()
        {
            var sqlExcerciseContext = _context.orders.Include(o => o.customer).Include(o => o.store);
            return View(await sqlExcerciseContext.ToListAsync());
        }

        // GET: orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.orders
                .Include(o => o.customer)
                .Include(o => o.store)
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: orders/Create
        public IActionResult Create()
        {
            ViewData["Customer_Id"] = new SelectList(_context.customers, "Customer_Id", "Customer_Id");
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email");
            return View();
        }

        // POST: orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order_Id,Customer_Id,Order_Status,Order_Date,Requried_Date,Shipped_Date,Store_Id,Staff_Id")] orders orders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customer_Id"] = new SelectList(_context.customers, "Customer_Id", "Customer_Id", orders.Customer_Id);
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", orders.Store_Id);
            return View(orders);
        }

        // GET: orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            ViewData["Customer_Id"] = new SelectList(_context.customers, "Customer_Id", "Customer_Id", orders.Customer_Id);
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", orders.Store_Id);
            return View(orders);
        }

        // POST: orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Order_Id,Customer_Id,Order_Status,Order_Date,Requried_Date,Shipped_Date,Store_Id,Staff_Id")] orders orders)
        {
            if (id != orders.Order_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ordersExists(orders.Order_Id))
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
            ViewData["Customer_Id"] = new SelectList(_context.customers, "Customer_Id", "Customer_Id", orders.Customer_Id);
            ViewData["Store_Id"] = new SelectList(_context.Set<stores>(), "Store_Id", "Email", orders.Store_Id);
            return View(orders);
        }

        // GET: orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.orders
                .Include(o => o.customer)
                .Include(o => o.store)
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orders = await _context.orders.FindAsync(id);
            _context.orders.Remove(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ordersExists(int id)
        {
            return _context.orders.Any(e => e.Order_Id == id);
        }
    }
}
