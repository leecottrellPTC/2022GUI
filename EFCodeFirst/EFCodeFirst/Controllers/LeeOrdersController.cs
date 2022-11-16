using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCodeFirst.Models;

namespace EFCodeFirst.Controllers
{
    public class LeeOrdersController : Controller
    {
        private readonly AzureContext _context;

        public LeeOrdersController(AzureContext context)
        {
            _context = context;
        }

        // GET: LeeOrders
        public async Task<IActionResult> Index()
        {
              return View(await _context.LeeOrders.ToListAsync());
        }

        // GET: LeeOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.LeeOrders == null)
            {
                return NotFound();
            }

            var leeOrder = await _context.LeeOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (leeOrder == null)
            {
                return NotFound();
            }

            return View(leeOrder);
        }

        // GET: LeeOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeeOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,CustomerID,EmpID,OrderDate")] LeeOrder leeOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leeOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leeOrder);
        }

        // GET: LeeOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeeOrders == null)
            {
                return NotFound();
            }

            var leeOrder = await _context.LeeOrders.FindAsync(id);
            if (leeOrder == null)
            {
                return NotFound();
            }
            return View(leeOrder);
        }

        // POST: LeeOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,CustomerID,EmpID,OrderDate")] LeeOrder leeOrder)
        {
            if (id != leeOrder.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leeOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeeOrderExists(leeOrder.OrderID))
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
            return View(leeOrder);
        }

        // GET: LeeOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeeOrders == null)
            {
                return NotFound();
            }

            var leeOrder = await _context.LeeOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (leeOrder == null)
            {
                return NotFound();
            }

            return View(leeOrder);
        }

        // POST: LeeOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeeOrders == null)
            {
                return Problem("Entity set 'AzureContext.LeeOrders'  is null.");
            }
            var leeOrder = await _context.LeeOrders.FindAsync(id);
            if (leeOrder != null)
            {
                _context.LeeOrders.Remove(leeOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeeOrderExists(int id)
        {
          return _context.LeeOrders.Any(e => e.OrderID == id);
        }
    }
}
