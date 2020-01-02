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
            //IEnumerable<StoreMaster> Stores = _context.Stores.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            //var totalStores = _context.Stores.Count();
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);                      
            var viewModel = from str in _context.Stores
                            join imp in _context.Importers on str.ImporterName equals imp.Id.ToString()
                            join dlr in _context.Dealers on str.DealerName equals dlr.Id.ToString()
                            join stgp in _context.StoreGroups on str.StoreGroupName equals stgp.Id.ToString()
                            where str.ImporterName == imp.Id.ToString()
                            //where ast.AssetCategory == astC.Id
                            //where ast.ControllerType == ctr.Id
                            where str.IsDeleted == false
                            where str.CreatedBy == userId
                            select new
                            {
                                str.Id,
                                impName = imp.ImporterName,
                                dlrName = dlr.DealerName,
                                stgpName = stgp.StoreGroupName,
                                str.Region,
                                str.Area,
                                str.StoreCode,
                                str.Type,
                                str.StoreName,
                                str.StoreAddress1,
                                str.StoreAddress2,
                                str.StorePhone,
                                str.StoreContact,
                                str.Zone,
                                str.PostTown,
                                str.StorePostcode,


                            };
            if (User.IsInRole("Administrator"))
            {
                viewModel = from str in _context.Stores
                            join imp in _context.Importers on str.ImporterName equals imp.Id.ToString()
                            join dlr in _context.Dealers on str.DealerName equals dlr.Id.ToString()
                            join stgp in _context.StoreGroups on str.StoreGroupName equals stgp.Id.ToString()
                            where str.ImporterName == imp.Id.ToString()
                            //where ast.AssetCategory == astC.Id
                            //where ast.ControllerType == ctr.Id
                            where str.IsDeleted == false
                            //where str.CreatedBy == userId
                            select new
                            {
                                str.Id,
                                impName = imp.ImporterName,
                                dlrName = dlr.DealerName,
                                stgpName = stgp.StoreGroupName,
                                str.Region,
                                str.Area,
                                str.StoreCode,
                                str.Type,
                                str.StoreName,
                                str.StoreAddress1,
                                str.StoreAddress2,
                                str.StorePhone,
                                str.StoreContact,
                                str.Zone,
                                str.PostTown,
                                str.StorePostcode,


                            };
            }
                var totalStoreGroups = viewModel.ToList().Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) viewModel = viewModel.Where(z => z.impName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.dlrName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.stgpName.ToString().ToLower().Contains(param.sSearch.ToLower())                                                                                
                                                                                || z.StoreCode.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Type.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreName.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress1.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress2.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StorePhone.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreContact.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Zone.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Area.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Region.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PostTown.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StorePostcode.ToString().ToLower().Contains(param.sSearch.ToLower()));                                                                                
            switch (sortColumnIndex)
            {
                case 1:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.impName) : viewModel.OrderByDescending(z => z.impName);
                    break;
                case 2:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.dlrName) : viewModel.OrderByDescending(z => z.dlrName);
                    break;
                case 3:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.stgpName) : viewModel.OrderByDescending(z => z.stgpName);
                    break;                
                case 4:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreCode) : viewModel.OrderByDescending(z => z.StoreCode);
                    break;
                case 5:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Type) : viewModel.OrderByDescending(z => z.Type);
                    break;
                case 6:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreName) : viewModel.OrderByDescending(z => z.StoreName);
                    break;
                case 7:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreAddress1) : viewModel.OrderByDescending(z => z.StoreAddress1);
                    break;
                case 8:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreAddress2) : viewModel.OrderByDescending(z => z.StoreAddress2);
                    break;
                case 9:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StorePhone) : viewModel.OrderByDescending(z => z.StorePhone);
                    break;
                case 10:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StoreContact) : viewModel.OrderByDescending(z => z.StoreContact);
                    break;
                case 11:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Zone) : viewModel.OrderByDescending(z => z.Zone);
                    break;
                case 12:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Area) : viewModel.OrderByDescending(z => z.Area);
                    break;
                case 13:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Region) : viewModel.OrderByDescending(z => z.Region);
                    break;
                case 14:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.PostTown) : viewModel.OrderByDescending(z => z.PostTown);
                    break;
                case 15:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.StorePostcode) : viewModel.OrderByDescending(z => z.StorePostcode);
                    break;
                default:
                    viewModel = viewModel.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredStoresCount = viewModel.Count();
            viewModel = viewModel.Skip(param.iDisplayStart).Take(param.iDisplayLength);
            return Json(new
            {
                sEcho = param.sEcho,
                //    iTotalRecords = totalStores,
                iTotalRecords = filteredStoresCount,
                iTotalDisplayRecords = filteredStoresCount,
                aaData = viewModel
            });
        }
        
        public IActionResult CreateStore()
        {
            List<ImporterMaster> Importer = new List<ImporterMaster>();
            List<DealerMaster> Dealer = new List<DealerMaster>();
            List<StoreGroupMaster> StoreGroup = new List<StoreGroupMaster>();

            Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
            Dealer = (from lists in _context.Dealers.Where(x => x.IsDeleted == false) select lists).ToList();
            StoreGroup = (from lists in _context.StoreGroups.Where(x => x.IsDeleted == false) select lists).ToList();

            Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--" });
            Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--" });
            StoreGroup.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "--Select--" });

            ViewBag.ImporterList = Importer;
            ViewBag.DealerList = Dealer;
            ViewBag.StoreGroupList = StoreGroup;

            return View();
        }

        // POST: StoreMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStore([Bind("Id,ImporterName,DealerName,StoreGroupName,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,StorePhone,StoreContact,Zone,Area,Region,PostTown,StorePostcode,IsDeleted,CreatedBy,ModifiedBy")] StoreMaster storeMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                //   var userName = _context.Users.Where(x => x.Id == user).Select(x=>x.FirstName+" "+x.LastName).FirstOrDefault() ;
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
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
            {
                List<ImporterMaster> Importer = new List<ImporterMaster>();
                List<DealerMaster> Dealer = new List<DealerMaster>();
                List<StoreGroupMaster> StoreGroup = new List<StoreGroupMaster>();

                Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
                Dealer = (from lists in _context.Dealers.Where(x => x.IsDeleted == false) select lists).ToList();
                StoreGroup = (from lists in _context.StoreGroups.Where(x => x.IsDeleted == false) select lists).ToList();

                Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--" });
                Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--" });
                StoreGroup.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "--Select--" });

                ViewBag.ImporterListEdit = Importer;
                ViewBag.DealerListEdit = Dealer;
                ViewBag.StoreGroupListEdit = StoreGroup;

                return View(storeMaster);
            }
        }

        // POST: StoreMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStore(int id, [Bind("Id,ImporterName,DealerName,StoreGroupName,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,StorePhone,StoreContact,Zone,Area,Region,PostTown,StorePostcode,IsDeleted,CreatedBy,ModifiedBy")] StoreMaster storeMaster)
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
                    //var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                    storeMaster.ModifiedBy = userName;
                    _context.Update(storeMaster);
                    _context.SaveChanges();
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
