using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Salesforecast.Models
{
    public class OrderdetailsController : Controller
    {
        private readonly testContext _context;

        public OrderdetailsController(testContext context)
        {
            _context = context;
        }

        // GET: Orderdetails
        public async Task<IActionResult> Index()
        {
            var testContext = _context.Orderdetails.Include(o => o.Order);
            return View(await testContext.ToListAsync());
        }

        // GET: Orderdetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderdetails = await _context.Orderdetails
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderdetails == null)
            {
                return NotFound();
            }

            return View(orderdetails);
        }

        // GET: Orderdetails/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
            return View();
        }

        // POST: Orderdetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,ProductId,Category,SubCategory,ProductName,Sales,Quantity,Discount,Profit,Id")] Orderdetails orderdetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderdetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderdetails.OrderId);
            return View(orderdetails);
        }

        // GET: Orderdetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderdetails = await _context.Orderdetails.FindAsync(id);
            if (orderdetails == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderdetails.OrderId);
            return View(orderdetails);
        }

        // POST: Orderdetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,ProductId,Category,SubCategory,ProductName,Sales,Quantity,Discount,Profit,Id")] Orderdetails orderdetails)
        {
            if (id != orderdetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderdetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderdetailsExists(orderdetails.Id))
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
            ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderdetails.OrderId);
            return View(orderdetails);
        }

        // GET: Orderdetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderdetails = await _context.Orderdetails
                .Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderdetails == null)
            {
                return NotFound();
            }

            return View(orderdetails);
        }

        // POST: Orderdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderdetails = await _context.Orderdetails.FindAsync(id);
            _context.Orderdetails.Remove(orderdetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderdetailsExists(int id)
        {
            return _context.Orderdetails.Any(e => e.Id == id);
        }
    }
}
