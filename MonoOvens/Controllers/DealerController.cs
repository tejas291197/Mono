using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonoOvens.Models;

namespace MonoOvens.Controllers
{
    public class DealerController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public DealerController(MonoContext context,UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Dealer
        public async Task<IActionResult> DealersList()
        {
            return View(await _context.Dealers.ToListAsync());
        }



        //data provider method for the Dealers list.
        public JsonResult DealerAjaxDataProvider(GridPagination param)
        {
            
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
          //  IEnumerable<DealerMaster> Dealers = _context.Dealers;
            IEnumerable<DealerMaster> Dealers = _context.Dealers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalDealers = _context.Dealers.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) Dealers = Dealers.Where(z => z.DealerName.ToLower().Contains(param.sSearch.ToLower() )
                                                                                || z.DealerPhone.ToString().ToLower().Contains(param.sSearch.ToLower() )
                                                                                || z.DealerRegion.ToLower().Contains(param.sSearch.ToLower() )  );

            switch (sortColumnIndex)
            {
                case 1:
                    Dealers = sortDirection == "asc" ? Dealers.OrderBy(z => z.DealerName) : Dealers.OrderByDescending(z => z.DealerName);
                    break;
                case 2:
                    Dealers = sortDirection == "asc" ? Dealers.OrderBy(z => z.DealerRegion) : Dealers.OrderByDescending(z => z.DealerRegion);
                    break;
                case 3:
                    Dealers = sortDirection == "asc" ? Dealers.OrderBy(z => z.DealerPhone) : Dealers.OrderByDescending(z => z.DealerPhone);
                    break;
             
                default:
                    Dealers = Dealers.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredDealersCount = Dealers.Count();
            Dealers = Dealers.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalDealers,
                iTotalDisplayRecords = filteredDealersCount,
                aaData = Dealers
            });
        }
        // GET: Dealer/Details/5
        public async Task<IActionResult> DealerDetails(int? id)
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
        public IActionResult CreateDealer()
        {
            return View();
        }

        // POST: Dealer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDealer([Bind("Id,DealerName,DealerPhone,DealerRegion")] DealerMaster dealerMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dealerMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DealersList));
            }
            return View(dealerMaster);
        }

        // GET: Dealer/Edit/5
        public async Task<IActionResult> EditDealer(int? id)
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
        public async Task<IActionResult> EditDealer(int id, [Bind("Id,DealerName,DealerPhone,DealerRegion")] DealerMaster dealerMaster)
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
                return RedirectToAction(nameof(DealersList));
            }
            return View(dealerMaster);
        }


        //To soft delete a record.
        public JsonResult Delete(int? id)
        {
            if (id == null)
            {
                return Json(new
                {
                    success = 0
                });
                //return RedirectToAction("NotFound", "Home");
            }
            var dealer = _context.Dealers.Find(id);
            //  _context.Customers.Remove(customer);
            if (dealer.IsDeleted == false)
            {
                dealer.IsDeleted = true;   // flag for a soft delete is set.
            }
            var result = _context.SaveChanges();
            if (result != 0)
            {
                return Json(new
                {
                    success = 1
                });
            }
            else
            {
                return Json(new
                {
                    success = 0
                });
            }
        }

        //// GET: Dealer/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var dealerMaster = await _context.Dealers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (dealerMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(dealerMaster);
        //}



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<JsonResult> DeleteConfirmed(int? id)
        //{
        //    if (id == null)
        //    {
        //        return Json(new
        //        {
        //            success = 0
        //        });
        //    }
        //    else
        //    {
        //        var dealerMaster = await _context.Dealers.FindAsync(id);
        //        _context.Dealers.Remove(dealerMaster); 
        //        await _context.SaveChangesAsync(); 
        //        return Json(new{
        //            success = 1
        //        });
        //    }

        //}
        //// POST: Dealer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var dealerMaster = await _context.Dealers.FindAsync(id);
        //    _context.Dealers.Remove(dealerMaster);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(DealersList));
        //}

        private bool DealerMasterExists(int id)
        {
            return _context.Dealers.Any(e => e.Id == id);
        }
    }
}
