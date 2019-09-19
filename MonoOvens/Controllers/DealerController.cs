using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonoOvens.Models;

namespace MonoOvens.Controllers
{
    public class DealerController : Controller
    {
        private readonly MonoContext _context;

        public DealerController(MonoContext context)
        {
            _context = context;
        }

        // GET: Dealer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dealers.ToListAsync());
        }

        // GET: Dealer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealerMaster = await _context.Dealers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealerMaster == null)
            {
                return NotFound();
            }

            return View(dealerMaster);
        }

        // GET: Dealer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dealer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DealerId,DealerName,DealerPhone,DealerEmail,DealerAddressLine1,DealerAddressLine2,DealerArea,DealerCity,DealerState,DealerCountry")] DealerMaster dealerMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dealerMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dealerMaster);
        }

        // GET: Dealer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealerMaster = await _context.Dealers.FindAsync(id);
            if (dealerMaster == null)
            {
                return NotFound();
            }
            return View(dealerMaster);
        }

        // POST: Dealer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DealerId,DealerName,DealerPhone,DealerEmail,DealerAddressLine1,DealerAddressLine2,DealerArea,DealerCity,DealerState,DealerCountry")] DealerMaster dealerMaster)
        {
            if (id != dealerMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dealerMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DealerMasterExists(dealerMaster.Id))
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
            return View(dealerMaster);
        }

        // GET: Dealer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealerMaster = await _context.Dealers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dealerMaster == null)
            {
                return NotFound();
            }

            return View(dealerMaster);
        }

        // POST: Dealer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dealerMaster = await _context.Dealers.FindAsync(id);
            _context.Dealers.Remove(dealerMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DealerMasterExists(int id)
        {
            return _context.Dealers.Any(e => e.Id == id);
        }
    }
}
