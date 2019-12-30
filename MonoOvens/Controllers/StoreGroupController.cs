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
            //IEnumerable<StoreGroupMaster> StoreGroups = _context.StoreGroups.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            //var totalStoreGroups = _context.StoreGroups.Count();           
            var viewModel = from stgp in _context.StoreGroups
                            join imp in _context.Importers on stgp.ImporterName equals imp.Id.ToString()
                            join dlr in _context.Dealers on stgp.DealerName equals dlr.Id.ToString()
                            //join astC in _context.AssetCategory on ast.AssetCategory equals astC.Id
                            where stgp.ImporterName == imp.Id.ToString()
                            //where ast.AssetCategory == astC.Id
                            //where ast.ControllerType == ctr.Id
                            where stgp.IsDeleted == false
                            where stgp.CreatedBy == userId
                            select new
                            {
                                stgp.Id,
                                impName = imp.ImporterName,
                                dlrName = dlr.DealerName,
                                stgp.Region,
                                stgp.Area,
                             
                                stgp.City,
                                stgp.HOAddress1,
                                stgp.HOAddress2,
                                stgp.HOAddress3,
                                stgp.Postcode,
                                stgp.StoreGroupName,
                                stgp.StoreGroupPhone,
                                stgp.StoreGroupRegion,
                                stgp.Email,
                                
                            };
            if (User.IsInRole("Administrator"))
            {
                viewModel = from stgp in _context.StoreGroups
                            join imp in _context.Importers on stgp.ImporterName equals imp.Id.ToString()
                            join dlr in _context.Dealers on stgp.DealerName equals dlr.Id.ToString()
                            //join astC in _context.AssetCategory on ast.AssetCategory equals astC.Id
                            where stgp.ImporterName == imp.Id.ToString()
                            //where ast.AssetCategory == astC.Id
                            //where ast.ControllerType == ctr.Id
                            where stgp.IsDeleted == false
                           // where stgp.CreatedBy == userId
                            select new
                            {
                                stgp.Id,
                                impName = imp.ImporterName,
                                dlrName = dlr.DealerName,
                                stgp.Region,
                                stgp.Area,

                                stgp.City,
                                stgp.HOAddress1,
                                stgp.HOAddress2,
                                stgp.HOAddress3,
                                stgp.Postcode,
                                stgp.StoreGroupName,
                                stgp.StoreGroupPhone,
                                stgp.StoreGroupRegion,
                                stgp.Email,

                            };
            }
                var totalStoreGroups = viewModel.ToList().Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) viewModel = viewModel.Where(z => z.dlrName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.impName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupPhone.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreGroupRegion.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Email.ToLower().Contains(param.sSearch.ToLower())
                                                                                //|| z.Region.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                //|| z.Area.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.HOAddress1.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.HOAddress2.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                //|| z.HOAddress3.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.City.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Postcode.ToString().ToLower().Contains(param.sSearch.ToLower()));


            switch (sortColumnIndex)
            {
                case 1:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.impName) : viewModel.OrderByDescending(z => z.impName);
                    break;
                case 2:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.dlrName) : viewModel.OrderByDescending(z => z.dlrName);
                    break;
                case 3:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreGroupName) : viewModel.OrderByDescending(z => z.StoreGroupName);
                    break;
                case 4:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreGroupPhone) : viewModel.OrderByDescending(z => z.StoreGroupName);
                    break;
                case 5:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreGroupRegion) : viewModel.OrderByDescending(z => z.StoreGroupRegion);
                    break;
                case 6:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Email) : viewModel.OrderByDescending(z => z.Email);
                    break;
                case 7:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Region) : viewModel.OrderByDescending(z => z.Region);
                    break;
                case 8:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Area) : viewModel.OrderByDescending(z => z.Area);
                    break;               
                case 9:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.HOAddress1 + " " + z.HOAddress2 + " " + z.HOAddress3 + " " + z.City + " " + z.Postcode) : viewModel.OrderByDescending(z => z.HOAddress1 + " " + z.HOAddress2 + " " + z.HOAddress3 + " " + z.City + " " + z.Postcode);
                    break;
                default:
                    viewModel = viewModel.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredStoreGroupsCount = viewModel.Count();
            viewModel = viewModel.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                //  iTotalRecords = totalStoreGroups,
                iTotalRecords = filteredStoreGroupsCount,
                iTotalDisplayRecords = filteredStoreGroupsCount,
                aaData = viewModel
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
            List<ImporterMaster> Importer = new List<ImporterMaster>();
            List<DealerMaster> Dealer = new List<DealerMaster>();

            Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
            Dealer = (from lists in _context.Dealers.Where(x => x.IsDeleted == false) select lists).ToList();

            Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--" });
            Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--" });

            ViewBag.ImporterList = Importer;
            ViewBag.DealerList = Dealer;

            return View();
        }

        // POST: StoreGroupMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStoreGroup([Bind("Id,ImporterName,DealerName,StoreGroupName,StoreGroupPhone,StoreGroupRegion,Email,Region,Area,HOAddress1,HOAddress2,HOAddress3,City,Postcode,IsDeleted,CreatedBy")] StoreGroupMaster storeGroupMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                //   var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
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
            {
                List<ImporterMaster> Importer = new List<ImporterMaster>();
                List<DealerMaster> Dealer = new List<DealerMaster>();

                Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
                Dealer = (from lists in _context.Dealers.Where(x => x.IsDeleted == false) select lists).ToList();

                Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--" });
                Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--" });

                ViewBag.ImporterList = Importer;
                ViewBag.DealerList = Dealer;
            }
            return View(storeGroupMaster);
        }

        // POST: StoreGroupMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStoreGroup(int id, [Bind("Id,ImporterName,DealerName,StoreGroupName,StoreGroupPhone,StoreGroupRegion,Email,Region,Area,HOAddress1,HOAddress2,HOAddress3,City,Postcode,IsDeleted,CreatedBy")] StoreGroupMaster storeGroupMaster)
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
                    // var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
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

