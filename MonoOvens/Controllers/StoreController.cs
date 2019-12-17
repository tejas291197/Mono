using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonoOvens.Models;

namespace MonoOvens.Controllers
{
    public class StoreController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public StoreController(MonoContext context,UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Store
        public async Task<IActionResult> StoreList()
        {
            return View(await _context.Stores.ToListAsync());
        }
        public JsonResult StoreAjaxDataProvider(GridPagination param)
        {
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            IEnumerable<StoreMaster> Stores = _context.Stores.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalStores = _context.Stores.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) Stores = Stores.Where(z => z.ImporterName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.DealerName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.CustomerName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.CustomerPhone.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Email.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Region.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Area.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreCode.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Type.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress1.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress2.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PostTown.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StorePostcode.ToString().ToLower().Contains(param.sSearch.ToLower()));                                                                                
            switch (sortColumnIndex)
            {
                case 1:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.ImporterName) : Stores.OrderByDescending(z => z.ImporterName);
                    break;
                case 2:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.DealerName) : Stores.OrderByDescending(z => z.DealerName);
                    break;
                case 3:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StoreGroupName) : Stores.OrderByDescending(z => z.StoreGroupName);
                    break;
                case 4:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.CustomerName) : Stores.OrderByDescending(z => z.CustomerName);
                    break;
                case 5:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.CustomerPhone) : Stores.OrderByDescending(z => z.CustomerPhone);
                    break;
                case 6:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.Email) : Stores.OrderByDescending(z => z.Email);
                    break;
                case 7:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.Region) : Stores.OrderByDescending(z => z.Region);
                    break;
                case 8:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.Area) : Stores.OrderByDescending(z => z.Area);
                    break;
                case 9:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StoreCode) : Stores.OrderByDescending(z => z.StoreCode);
                    break;
                case 10:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.Type) : Stores.OrderByDescending(z => z.Type);
                    break;
                case 11:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StoreName) : Stores.OrderByDescending(z => z.StoreName);
                    break;
                case 12:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StoreAddress1) : Stores.OrderByDescending(z => z.StoreAddress1);
                    break;
                case 13:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StoreAddress2) : Stores.OrderByDescending(z => z.StoreAddress2);
                    break;
                case 14:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.PostTown) : Stores.OrderByDescending(z => z.PostTown);
                    break;
                case 15:
                    Stores = sortDirection == "asc" ? Stores.OrderBy(z => z.StorePostcode) : Stores.OrderByDescending(z => z.StorePostcode);
                    break;
                default:
                    Stores = Stores.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredStoresCount = Stores.Count();
            Stores = Stores.Skip(param.iDisplayStart).Take(param.iDisplayLength);
            return Json(new
            {
                sEcho = param.sEcho,
                //    iTotalRecords = totalStores,
                iTotalRecords = filteredStoresCount,
                iTotalDisplayRecords = filteredStoresCount,
                aaData = Stores
            });
        }
        
        public IActionResult CreateStore()
        {
            return View();
        }

        // POST: StoreMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStore([Bind("Id,ImporterName,DealerName,StoreGroupName,CustomerName,CustomerPhone,Email,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode,IsDeleted,CreatedBy")] StoreMaster storeMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                var userName = _context.Users.Where(x => x.Id == user).Select(x=>x.FirstName+" "+x.LastName).FirstOrDefault() ;
                storeMaster.CreatedBy =  userName;
                _context.Add(storeMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(StoreList));
            }
            return View(storeMaster);
        }

        // GET: StoreMasters/Edit/5
        public async Task<IActionResult> EditStore(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeMaster = await _context.Stores.FindAsync(id);
            if (storeMaster == null)
            {
                return NotFound();
            }
            return View(storeMaster);
        }

        // POST: StoreMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStore(int id, [Bind("Id,ImporterName,DealerName,StoreGroupName,CustomerName,CustomerPhone,Email,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode,IsDeleted,CreatedBy")] StoreMaster storeMaster)
        {
            if (id != storeMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = _userManager.GetUserId(User);
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    storeMaster.ModifiedBy = userName;
                    _context.Update(storeMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (StoreMasterExists(storeMaster.Id))
                    {
                        throw;
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction(nameof(StoreList));
            }
            return View(storeMaster);
        }

        private bool StoreMasterExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: StoreMasters/Delete/5
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
            var Stores = _context.Stores.Find(id);
            //  _context.Customers.Remove(customer);
            if (Stores.IsDeleted == false)
            {
                Stores.IsDeleted = true;   // flag for a soft delete is set.
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




        // GET: StoreMasters/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var storeMaster = await _context.Stores
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (storeMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(storeMaster);
        //}

        // GET: StoreMasters/Create
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var storeMaster = await _context.Stores
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (storeMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(storeMaster);
        //}

        //// POST: StoreMasters/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var storeMaster = await _context.Stores.FindAsync(id);
        //    _context.Stores.Remove(storeMaster);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(StoreList));
        //}

        //private bool StoreMasterExists(int id)
        //{
        //    return _context.Stores.Any(e => e.Id == id);
        //}
    }
}
