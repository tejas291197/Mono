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
    public class ControllerModulesController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;
        private static int selectImpid;
        private static int selectDealerid;
        private static int selectStoreGroupid;

        public ControllerModulesController(MonoContext context,UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ControllerModules
        public async Task<IActionResult> ControllersList()
        {
            return View(await _context.Controller.ToListAsync());
        }
        public JsonResult ControllerAjaxData(GridPagination param)
        {
            //GridPagination param = new GridPagination();
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            //  IEnumerable<ControllerModule> Controllers = _context.Controller;
            IEnumerable<ControllerModule> Controllers = _context.Controller.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalControllers = _context.Controller.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) Controllers = Controllers.Where(z => z.AuthenticationCode.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.ControllerDate.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.FirmwareVersion.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.RecipeVersion.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.RemoteKill.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.SerialNumber.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.SevenDayTimer.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.Skins.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.SleepDelay.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.SoftwareVersion.ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.Status.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                        || z.Wallpaper.ToLower().Contains(param.sSearch.ToLower()));


            switch (sortColumnIndex)
            {
                case 1:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.FG_Code) : Controllers.OrderByDescending(z => z.FG_Code);
                    break;
                case 2:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.SerialNumber) : Controllers.OrderByDescending(z => z.SerialNumber);
                    break;
                case 3:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.AuthenticationCode) : Controllers.OrderByDescending(z => z.AuthenticationCode);
                    break;
                case 4:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.FirmwareVersion) : Controllers.OrderByDescending(z => z.FirmwareVersion);
                    break;
                case 5:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.SoftwareVersion) : Controllers.OrderByDescending(z => z.SoftwareVersion);
                    break;
                case 6:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.RecipeVersion) : Controllers.OrderByDescending(z => z.RecipeVersion);
                    break;
                case 7:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Skins) : Controllers.OrderByDescending(z => z.Skins);
                    break;
                case 8:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Wallpaper) : Controllers.OrderByDescending(z => z.Wallpaper);
                    break;
                case 9:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.SevenDayTimer) : Controllers.OrderByDescending(z => z.SevenDayTimer);
                    break;
                case 10:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.SleepDelay) : Controllers.OrderByDescending(z => z.SleepDelay);
                    break;
                case 11:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.ControllerDate) : Controllers.OrderByDescending(z => z.ControllerDate);
                    break;
                case 12:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Status) : Controllers.OrderByDescending(z => z.Status);
                    break;
                case 13:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.RemoteKill) : Controllers.OrderByDescending(z => z.RemoteKill);
                    break;                
                default:
                    Controllers = Controllers.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredControllersCount = Controllers.Count();
         //  Controllers = Controllers.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalControllers,
                iTotalDisplayRecords = filteredControllersCount,
                aaData = Controllers
            });
           
        }

        // GET: ControllerModules/Details/5
        public async Task<IActionResult> ControllerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var controllerModule = await _context.Controller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (controllerModule == null)
            {
                return NotFound();
            }

            return View(controllerModule);
        }

        // GET: ControllerModules/Create
        public IActionResult CreateController()
        {            
            List<AssetMaster> Asset = new List<AssetMaster>();

            Asset = (from lists in _context.Assets.Where(x => x.IsDeleted == false) select lists).ToList();

            Asset.Insert(0, new AssetMaster { Id = 0, FG_Code = "--Select--" });

            ViewBag.FGAsset = Asset;

            List<ImporterMaster> Importer = new List<ImporterMaster>();
            List<DealerMaster> Dealer = new List<DealerMaster>();
            List<StoreGroupMaster> StoreGroup = new List<StoreGroupMaster>();
            List<StoreMaster> Store = new List<StoreMaster>();

            Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
            Dealer = (from lists in _context.Dealers where lists.IsDeleted==false select lists).ToList();
            //  StoreGroup = (from lists in _context.StoreGroups.Where (/*x.IsDeleted == false || */lists.DealerName == id) select lists).ToList();
            // StoreGroup = (from lists in _context.StoreGroups where lists.ImporterName.Equals(id) select lists).ToList();
            StoreGroup = (from lists in _context.StoreGroups where lists.IsDeleted == false select lists).ToList();
            Store =  (from lists in _context.Stores where lists.IsDeleted == false select lists).ToList();
            // Store = (from lists in _context.Stores.Where(/*x => x.IsDeleted == false*/lists.StoreGroups == id) select lists).ToList();

            Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--" });
            Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--", ImporterName = "0" });
            StoreGroup.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "--Select--", DealerName = "0" });
            Store.Insert(0, new StoreMaster { Id = 0, StoreName = "--Select--", StoreGroupName = "0" });

            ViewBag.ImporterList = Importer;
            ViewBag.DealerList = Dealer;
            ViewBag.StoreGroupList = StoreGroup;
            ViewBag.StoreList = Store;

            return View();
        }
        public JsonResult GetDelearsListfromImporterId(int id)
        {
            selectImpid = id;
            List<DealerMaster> Dealers = new List<DealerMaster>();
            Dealers = (from lists in _context.Dealers where lists.ImporterName.Equals(id)  select lists).ToList();
            Dealers.Insert(0, new DealerMaster { Id = 0, DealerName = "---Select---", ImporterName = "0" });
            ViewBag.Dealers = Dealers;
                
            return Json(new
            {
                data = Dealers
            });
        }

        public JsonResult GetStoreGroupsListfromDealerId(int id)
        {
            selectDealerid = id;
            List<StoreGroupMaster> Storegrps = new List<StoreGroupMaster>();
            Storegrps = (from lists in _context.StoreGroups where lists.DealerName.Equals(id) select lists).ToList();
            Storegrps.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "---Select---", DealerName = "0" });
            ViewBag.StoreGroups = Storegrps;

            return Json(new
            {
                data = Storegrps
            });
        }


        public JsonResult GetStoresListfromStoreGroupId(int id)
        {
            selectStoreGroupid = id;
            List<StoreMaster> stores = new List<StoreMaster>();
            stores = (from lists in _context.Stores where lists.StoreGroupName.Equals(id) select lists).ToList();
            stores.Insert(0, new StoreMaster { Id = 0, StoreName = "---Select---", StoreGroupName = "0" });
            ViewBag.Stores = stores;

            return Json(new
            {
                data = stores
            });
        }
        // POST: ControllerModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateController([Bind("Id,FG_Code,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins," +
            "Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status,RemoteKill,IsDeleted,ModifiedBy,CreatedBy")] ControllerModule controllerModule)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                //  var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                controllerModule.CreatedBy = userName;
                _context.Add(controllerModule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ControllersList));
            }            
            return View(controllerModule);
        }

        // GET: ControllerModules/Edit/5
        public async Task<IActionResult> EditController(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var controllerModule = await _context.Controller.FindAsync(id);
            if (controllerModule == null)
            {
                return NotFound();
            }
            {
                //selectImpid = id;

                List<AssetMaster> Asset = new List<AssetMaster>();

                Asset = (from lists in _context.Assets.Where(x => x.IsDeleted == false) select lists).ToList();

                Asset.Insert(0, new AssetMaster { Id = 0, FG_Code="--Select--"});

                ViewBag.FGAssetedit = Asset;

                List<ImporterMaster> Importer = new List<ImporterMaster>();
                List<DealerMaster> Dealer = new List<DealerMaster>();
                List<StoreGroupMaster> StoreGroup = new List<StoreGroupMaster>();
                List<StoreMaster> Store = new List<StoreMaster>();

                Importer = (from lists in _context.Importers.Where(x => x.IsDeleted == false) select lists).ToList();
                Dealer = (from lists in _context.Dealers.Where(x => x.IsDeleted == false) select lists).ToList();
                StoreGroup = (from lists in _context.StoreGroups.Where(x => x.IsDeleted == false) select lists).ToList();
                Store = (from lists in _context.Stores.Where(x => x.IsDeleted == false) select lists).ToList();

                Importer.Insert(0, new ImporterMaster { Id = 0, ImporterName = "--Select--"});
                Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "--Select--", ImporterName = "0" });
                StoreGroup.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "--Select--", DealerName = "0" });
                Store.Insert(0, new StoreMaster { Id = 0, StoreName = "--Select--", StoreGroupName = "0" });

                ViewBag.ImporterListEdit = Importer;
                ViewBag.DealerListEdit = Dealer;
                ViewBag.StoreGroupListEdit = StoreGroup;
                ViewBag.StoreListEdit = Store;
            }
            return View(controllerModule);
        }

        // POST: ControllerModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditController(int id,[Bind("Id,FG_Code,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins,Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status" +
            "RemoteKill,IsDeleted,ModifiedBy,CreatedBy")] ControllerModule controllerModule)
        {
            if (id != controllerModule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = _userManager.GetUserId(User);
                    //  var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                    controllerModule.ModifiedBy = userName;
                    _context.Update(controllerModule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ControllerModuleExists(controllerModule.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ControllersList));
            }
            return View(controllerModule);
        }
        public JsonResult GetDealerNameByImpoterName(int id)
        {
            selectImpid = id;
            List<DealerMaster> Dealer = new List<DealerMaster>();
            Dealer = (from lists in _context.Dealers where lists.ImporterName == "id" select lists).ToList();
            Dealer.Insert(0, new DealerMaster { Id = 0, DealerName = "---Select---", ImporterName = "0" });
            ViewBag.DealerList = Dealer;     
            
            return Json(new
            {
                data = Dealer
            });
        }
        public JsonResult GetStoreGroupsListEditfromDealerId(int id)
        {
            selectDealerid = id;
            List<StoreGroupMaster> Storegrps = new List<StoreGroupMaster>();
            Storegrps = (from lists in _context.StoreGroups where lists.DealerName.Equals(id) select lists).ToList();
            Storegrps.Insert(0, new StoreGroupMaster { Id = 0, StoreGroupName = "---Select---", DealerName = "0" });
            ViewBag.StoreGroups = Storegrps;

            return Json(new
            {
                data = Storegrps
            });
        }


        public JsonResult GetStoresListEditfromStoreGroupId(int id)
        {
            selectStoreGroupid = id;
            List<StoreMaster> stores = new List<StoreMaster>();
            stores = (from lists in _context.Stores where lists.StoreGroupName.Equals(id) select lists).ToList();
            stores.Insert(0, new StoreMaster { Id = 0, StoreName = "---Select---", StoreGroupName="0" });
            ViewBag.Stores = stores;

            return Json(new
            {
                data = stores
            });
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
            var controllers = _context.Controller.Find(id);
            //  _context.Customers.Remove(customer);
            if (controllers.IsDeleted == false)
            {
                controllers.IsDeleted = true;   // flag for a soft delete is set.
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

        // GET: ControllerModules/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var controllerModule = await _context.Controller
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (controllerModule == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(controllerModule);
        //}




        // POST: Clients/Delete/5
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
        //        var controller = await _context.Controller.FindAsync(id);
        //        _context.Controller.Remove(controller);
        //        await _context.SaveChangesAsync();
        //        return Json(new
        //        {
        //            success = 1
        //        });
        //    }

        //}





        // POST: ControllerModules/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var controllerModule = await _context.Controller.FindAsync(id);
        //    _context.Controller.Remove(controllerModule);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(ControllersList));
        //}

        private bool ControllerModuleExists(int id)
        {
            return _context.Controller.Any(e => e.Id == id);
        }
    }
}
