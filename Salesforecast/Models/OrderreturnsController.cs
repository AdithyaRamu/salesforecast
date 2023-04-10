using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Salesforecast.Models
{
    public class OrderreturnsController : Controller
    {
        private readonly testContext _context;

        public OrderreturnsController(testContext context)
        {
            _context = context;
        }

        // GET: Orderreturns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orderreturns.ToListAsync());
        }

        // GET: Orderreturns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderreturns = await _context.Orderreturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderreturns == null)
            {
                return NotFound();
            }

            return View(orderreturns);
        }

        // GET: Orderreturns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orderreturns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,Comments,Id")] Orderreturns orderreturns)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderreturns);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderreturns);
        }

        // GET: Orderreturns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderreturns = await _context.Orderreturns.FindAsync(id);
            if (orderreturns == null)
            {
                return NotFound();
            }
            return View(orderreturns);
        }

        // POST: Orderreturns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,Comments,Id")] Orderreturns orderreturns)
        {
            if (id != orderreturns.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderreturns);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderreturnsExists(orderreturns.Id))
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
            return View(orderreturns);
        }

        // GET: Orderreturns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderreturns = await _context.Orderreturns
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderreturns == null)
            {
                return NotFound();
            }

            return View(orderreturns);
        }

        // POST: Orderreturns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderreturns = await _context.Orderreturns.FindAsync(id);
            _context.Orderreturns.Remove(orderreturns);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderreturnsExists(int id)
        {
            return _context.Orderreturns.Any(e => e.Id == id);
        }
    }
}
