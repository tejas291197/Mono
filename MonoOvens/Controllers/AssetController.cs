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
       public class AssetController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;
        private static int selectid;
        

        public AssetController(MonoContext context,UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Asset
        public async Task<IActionResult> AssetsList()
        {
            return View(await _context.Assets.ToListAsync());
        }


        //data provider method for the asset list.
        public JsonResult AssetAjaxDataProvider(GridPagination param)
        {
            // Thread.Sleep(7000);
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            //IEnumerable<AssetMaster> viewModel = _context.Assets;
            // IEnumerable<AssetMaster> viewModel = _context.Assets.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var viewModel = from ast in _context.Assets
                            join ctr in _context.ControllerType on ast.ControllerType equals ctr.Id
                            join astT in _context.AssetType on ast.AssetType equals astT.Id
                            join astC in _context.AssetCategory on ast.AssetCategory equals astC.Id
                            where ast.AssetType == astT.Id
                            where ast.AssetCategory == astC.Id
                            where ast.ControllerType == ctr.Id
                            where ast.IsDeleted == false
                            select new
                            {
                                ast.Id,
                                AssetCategory = astC.AssetCategory,
                                AssetType = astT.AssetType,
                                ControllerType = ctr.ControllerType,
                                ast.FG_Code,
                                ast.Controllers,
                                ast.Trays,
                                ast.TraySize,                         
                                ast.Handed,
                                ast.Format,
                                ast.Power,
                                ast.Elements,
                                ast.kWh_Rating_Element,
                                ast.LightType,
                                ast.Lights,
                                ast.kWh_Rating_Light,
                                ast.Fans,
                                ast.kWh_Rating_Fan,
                                ast.kWh_Rating_Damper,
                                ast.kWh_Rating_WaterSolenoid,


                            };




            //  var totalviewModel = _context.viewModel.Count();   
            var totalviewModel = viewModel.ToList().Count(); 
             var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) viewModel = viewModel.Where(z => z.AssetCategory.ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.AssetType.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.FG_Code.ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.Controllers.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.ControllerType.ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.Trays.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.TraySize.ToLower().Contains(param.sSearch.ToLower())                                                                            
                                                                             || z.Handed.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.Power.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.Elements.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             || z.Format.ToLower().Contains(param.sSearch.ToLower())) ;

            switch (sortColumnIndex)
            {
                case 1:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.FG_Code) : viewModel.OrderByDescending(x => x.FG_Code);
                    break;
                case 2:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.AssetCategory) : viewModel.OrderByDescending(z => z.AssetCategory);
                    break;
                case 3:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.AssetType) : viewModel.OrderByDescending(z => z.AssetType);
                    break;
                case 4:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.ControllerType) : viewModel.OrderByDescending(z => z.ControllerType);
                    break;
                case 5:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Controllers) : viewModel.OrderByDescending(z => z.Controllers);
                    break;
                case 6:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Trays) : viewModel.OrderByDescending(z => z.Trays);                  
                    break;
                case 7:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.TraySize) : viewModel.OrderByDescending(z => z.TraySize );
                    break;
                case 8:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Handed ) : viewModel.OrderByDescending(z => z.Handed);
                    break;
                case 9:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Format): viewModel.OrderByDescending(z => z.Format);
                    break;
                case 10:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Power) : viewModel.OrderByDescending(z => z.Power);
                    break;
                case 11:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Elements) : viewModel.OrderByDescending(z => z.Elements);
                    break;
                case 12:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.kWh_Rating_Element) : viewModel.OrderByDescending(z => z.kWh_Rating_Element);
                    break;
                case 13:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.LightType) : viewModel.OrderByDescending(z => z.LightType);
                    break;
                case 14:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Lights) : viewModel.OrderByDescending(z => z.Lights);
                    break;
                case 15:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.kWh_Rating_Light) : viewModel.OrderByDescending(z => z.kWh_Rating_Light);
                    break;
                case 16:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Fans) : viewModel.OrderByDescending(z => z.Fans);
                    break;
                case 17:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.kWh_Rating_Fan) : viewModel.OrderByDescending(z => z.kWh_Rating_Fan);
                    break;
                case 18:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.kWh_Rating_Damper) : viewModel.OrderByDescending(z => z.kWh_Rating_Damper);
                    break;
                case 19:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.kWh_Rating_WaterSolenoid) : viewModel.OrderByDescending(z => z.kWh_Rating_WaterSolenoid);
                    break;
                default:
                    viewModel = viewModel.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredviewModelCount = viewModel.Count();
            viewModel = viewModel.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = filteredviewModelCount,
                iTotalDisplayRecords = filteredviewModelCount,
                aaData = viewModel
            });
        }


        // GET: Asset/Details/5
        public async Task<IActionResult> AssetDetails(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Home/Notfound");
            }

            var assetMaster = await _context.Assets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assetMaster == null)
            {
                return NotFound();
            }

            return View(assetMaster);
        }

        // GET: Asset/Create
        public IActionResult CreateAsset()
        {
            List<AssetCategoryMaster> Category = new List<AssetCategoryMaster>();            
            List<ControllerTypeMaster> CType = new List<ControllerTypeMaster>();

            Category = (from lists in _context.AssetCategory select lists).ToList();         
            CType = (from lists in _context.ControllerType select lists).ToList();
            
            Category.Insert(0, new AssetCategoryMaster { Id= 0, AssetCategory = "---Select---" });       
            CType.Insert(0, new ControllerTypeMaster { Id = 0, ControllerType = "---Select---" });
            
            ViewBag.ACateogies = Category;         
            ViewBag.CTypes = CType;

            List<AssetTypeMaster> AType = new List<AssetTypeMaster>();
            AType = (from lists in _context.AssetType where lists.AssetCategoryId == selectid select lists).ToList();
            AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---", AssetCategoryId = 0 });
            ViewBag.ATypes = AType;
            //List<AssetTypeMaster> AType = new List<AssetTypeMaster>();
            //AType = (from lists in _context.AssetType select lists).ToList();
            //AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---" });
            //ViewBag.ATypes = AType;

            return View();
        }

        // POST: Asset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateAsset([Bind("Id,FG_Code,AssetCategory,AssetType,ControllerType," +
        //     "Controllers,Trays,TraySize,Handed,Format,Power,Elements,kWh_Rating_Element,LightType,Lights,kWh_Rating_Light,Fans," +
        //      "kWh_Rating_Fan,kWh_Rating_Damper,kWh_Rating_WaterSolenoid")] AssetMaster assetMaster)
        public async Task<IActionResult> CreateAsset([Bind("Id,FG_Code,AssetCategory,AssetType,ControllerType," +
            "Controllers,Trays,TraySize,Handed,Format,Power,Elements,kWh_Rating_Element,LightType,Lights,kWh_Rating_Light,Fans," +
              "kWh_Rating_Fan,kWh_Rating_Damper,kWh_Rating_WaterSolenoid,CreatedBy,modifiedby")] AssetMaster assetMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                //  var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                assetMaster.CreatedBy = userName;
                _context.Add(assetMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AssetsList));
            }
            return View(assetMaster);
        }

        // GET: Asset/Edit/5
        public async Task<IActionResult> EditAsset(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetMaster = await _context.Assets.FindAsync(id);
            if (assetMaster == null)
            {
                return NotFound();
            }
            List<AssetCategoryMaster> Category = new List<AssetCategoryMaster>();
            List<ControllerTypeMaster> CType = new List<ControllerTypeMaster>();
            List<AssetTypeMaster> AType = new List<AssetTypeMaster>();

            Category = (from lists in _context.AssetCategory select lists).ToList();
            CType = (from lists in _context.ControllerType select lists).ToList();
            AType = (from lists in _context.AssetType select lists).ToList();

            Category.Insert(0, new AssetCategoryMaster { Id = 0, AssetCategory = "---Select---" });
            CType.Insert(0, new ControllerTypeMaster { Id = 0, ControllerType = "---Select---" });
            AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---" });

            ViewBag.ACateogiesedit = Category;
            ViewBag.CTypesedit = CType;
            ViewBag.ATypesedit = AType;

            return View(assetMaster);
        }

        // POST: Asset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsset(int id, [Bind("Id,FG_Code,AssetCategory,AssetType,ControllerType,Controllers,Trays,TraySize,Handed,Format,Power,Elements,kWh_Rating_Element,LightType,Lights,kWh_Rating_Light,Fans," +
              "kWh_Rating_Fan,kWh_Rating_Damper,kWh_Rating_WaterSolenoid,modifiedby,CreatedBy")] AssetMaster assetMaster)

        //public async Task<IActionResult> EditAsset(int id, [Bind("Id,FG_Code,AssetCategory,AssetType,ControllerType,Controllers,Trays,TraySize,Handed,Format,Power")] AssetMaster assetMaster)
        {
            if (id != assetMaster.Id)
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
                    assetMaster.modifiedby = userName;
                    _context.Update(assetMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssetMasterExists(assetMaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AssetsList));
            }
            return View(assetMaster);
        }

        public JsonResult GetAssetTypeByAssetCategoryId(int id)
          {
            selectid = id;
            List<AssetTypeMaster> AType = new List<AssetTypeMaster>();
            AType = (from lists in _context.AssetType where lists.AssetCategoryId == id select lists).ToList();
            AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---" ,AssetCategoryId=0});
            ViewBag.ATypes = AType;
            //if (AType == null)
            //{
            //    return Json(new
            //    {
            //        data = null
            //    });
            //}         
            return Json(new
            {
               data = AType
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
            var asset = _context.Assets.Find(id);
            //  _context.Customers.Remove(customer);
            if (asset.IsDeleted == false)
            {
                asset.IsDeleted = true;   // flag for a soft delete is set.
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
        private bool AssetMasterExists(int id)
        {
            return _context.Assets.Any(e => e.Id == id);
        }
        // GET: Asset/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var assetMaster = await _context.Assets
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (assetMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(assetMaster);
        //}

        //json result is return from here when the record is deleted.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public JsonResult DeleteRecord(int id)
        //{
        //    //if(id == null)
        //    //{

        //    //}
        //    //else
        //    //{
        //        var assetMaster = _context.Assets.Find(id);
        //        _context.Assets.Remove(assetMaster);
        //        var result = _context.SaveChanges();
        //   // }
        //   if(result!=0)
        //    {
        //        return Json(new
        //        {
        //            success = 1
        //        });
        //    }
        //    else
        //    {
        //        return Json(new
        //        {
        //            success = 0
        //        });
        //    }

        //}
        // POST: Asset/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var assetMaster = await _context.Assets.FindAsync(id);
        //    _context.Assets.Remove(assetMaster);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(AssetsList));
        //}


    }
}
