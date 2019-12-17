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
    public class StoreGroupController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public StoreGroupController(MonoContext context, UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: StoreGroup
        public async Task<IActionResult> StoreGroupList()
        {
            return View(await _context.StoreGroups.ToListAsync());
        }

        public JsonResult StoreGroupAjaxDataProvider(GridPagination param)
        {

            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            IEnumerable<StoreGroupMaster> StoreGroups = _context.StoreGroups.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalStoreGroups = _context.StoreGroups.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) StoreGroups = StoreGroups.Where(z => z.DealerName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.ImporterName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupPhone.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupRegion.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Email.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Region.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Area.ToString().ToLower().Contains(param.sSearch.ToLower()));

            switch (sortColumnIndex)
            {
                case 1:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.ImporterName) : StoreGroups.OrderByDescending(z => z.ImporterName);
                    break;
                case 2:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.DealerName) : StoreGroups.OrderByDescending(z => z.DealerName);
                    break;
                case 3:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.StoreGroupName) : StoreGroups.OrderByDescending(z => z.StoreGroupName);
                    break;
                case 4:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.StoreGroupPhone) : StoreGroups.OrderByDescending(z => z.StoreGroupName);
                    break;
                case 5:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.StoreGroupRegion) : StoreGroups.OrderByDescending(z => z.StoreGroupRegion);
                    break;
                case 6:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.Email) : StoreGroups.OrderByDescending(z => z.Email);
                    break;
                case 7:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.Region) : StoreGroups.OrderByDescending(z => z.Region);
                    break;
                case 8:
                    StoreGroups = sortDirection == "asc" ? StoreGroups.OrderBy(z => z.Area) : StoreGroups.OrderByDescending(z => z.Area);
                    break;
                default:
                    StoreGroups = StoreGroups.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredStoreGroupsCount = StoreGroups.Count();
            StoreGroups = StoreGroups.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                //  iTotalRecords = totalStoreGroups,
                iTotalRecords = filteredStoreGroupsCount,
                iTotalDisplayRecords = filteredStoreGroupsCount,
                aaData = StoreGroups
            });
        }

        // GET: StoreGroupMasters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var storeGroupMaster = await _context.StoreGroups
                .FirstOrDefaultAsync(m => m.Id == id);
            if (storeGroupMaster == null)
            {
                return NotFound();
            }
            return View(storeGroupMaster);
        }

        // GET: StoreGroupMasters/Create
        public IActionResult CreateStoreGroup()
        {
            return View();
        }

        // POST: StoreGroupMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStoreGroup([Bind("Id,ImporterName,DealerName,StoreGroupName,StoreGroupPhone,StoreGroupRegion,Email,Region,Area,IsDeleted,CreatedBy")] StoreGroupMaster storeGroupMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                storeGroupMaster.CreatedBy = userName;
                _context.Add(storeGroupMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(StoreGroupList));
            }
            return View(storeGroupMaster);
        }

        // GET: StoreGroupMasters/Edit/5
        public async Task<IActionResult> EditStoreGroup(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storeGroupMaster = await _context.StoreGroups.FindAsync(id);
            if (storeGroupMaster == null)
            {
                return NotFound();
            }
            return View(storeGroupMaster);
        }

        // POST: StoreGroupMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStoreGroup(int id, [Bind("Id,ImporterName,DealerName,StoreGroupName,StoreGroupPhone,StoreGroupRegion,Email,Region,Area,IsDeleted,CreatedBy")] StoreGroupMaster storeGroupMaster)
        {
            if (id != storeGroupMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = _userManager.GetUserId(User);
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    storeGroupMaster.ModifiedBy = userName;
                    _context.Update(storeGroupMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreGroupMasterExists(storeGroupMaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(StoreGroupList));
            }
            return View(storeGroupMaster);
        }

        private bool StoreGroupMasterExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: StoreGroupMasters/Delete/5
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
            var StoreGroup = _context.StoreGroups.Find(id);
            //  _context.Customers.Remove(customer);
            if (StoreGroup.IsDeleted == false)
            {
                StoreGroup.IsDeleted = true;   // flag for a soft delete is set.
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
            //public async Task<IActionResult> Delete(int? id)
            //{
            //    if (id == null)
            //    {
            //        return NotFound();
            //    }
            //    var storeGroupMaster = await _context.StoreGroups
            //        .FirstOrDefaultAsync(m => m.Id == id);
            //    if (storeGroupMaster == null)
            //    {
            //        return NotFound();
            //    }
            //    return View(storeGroupMaster);
            //}

            //// POST: StoreGroupMasters/Delete/5
            //[HttpPost, ActionName("Delete")]
            //[ValidateAntiForgeryToken]
            //public async Task<IActionResult> DeleteConfirmed(int id)
            //{
            //    var storeGroupMaster = await _context.StoreGroups.FindAsync(id);
            //    _context.StoreGroups.Remove(storeGroupMaster);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(StoreGroupList));
            //}

            //private bool StoreGroupMasterExists(int id)
            //{
            //    return _context.StoreGroups.Any(e => e.Id == id);
            //}
        }
    }
}

