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
    public class order_itemsController : Controller
    {
        private readonly Sqlmv_ProjectContext _context;

        public order_itemsController(Sqlmv_ProjectContext context)
        {
            _context = context;
        }

        // GET: order_items
        public async Task<IActionResult> Index()
        {
            return View(await _context.order_items.ToListAsync());
        }

        // GET: order_items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_items = await _context.order_items
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (order_items == null)
            {
                return NotFound();
            }

            return View(order_items);
        }

        // GET: order_items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: order_items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Order_Id,Item_Id,Product_Id,Quantity,List_Price,Discount")] order_items order_items)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order_items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order_items);
        }

        // GET: order_items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_items = await _context.order_items.FindAsync(id);
            if (order_items == null)
            {
                return NotFound();
            }
            return View(order_items);
        }

        // POST: order_items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Order_Id,Item_Id,Product_Id,Quantity,List_Price,Discount")] order_items order_items)
        {
            if (id != order_items.Order_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order_items);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!order_itemsExists(order_items.Order_Id))
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
            return View(order_items);
        }

        // GET: order_items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order_items = await _context.order_items
                .FirstOrDefaultAsync(m => m.Order_Id == id);
            if (order_items == null)
            {
                return NotFound();
            }

            return View(order_items);
        }

        // POST: order_items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order_items = await _context.order_items.FindAsync(id);
            _context.order_items.Remove(order_items);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool order_itemsExists(int id)
        {
            return _context.order_items.Any(e => e.Order_Id == id);
        }
    }
}
