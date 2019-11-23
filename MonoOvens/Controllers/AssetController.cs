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
            //  IEnumerable<AssetMaster> viewModel = _context.Assets.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
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
                                ast.Controllers,
                                ast.Trays,
                                ast.TrayHeight_inch,
                                ast.TrayWidth_inch,
                                ast.Handed,
                                ast.Format,
                                ast.Power,
                                ast.PowerConsumption

                            };




            //  var totalviewModel = _context.viewModel.Count();   
            var totalviewModel = viewModel.ToList().Count(); 
             var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) viewModel = viewModel.Where(z => z.AssetCategory.ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.AssetType.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.Controllers.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.ControllerType.ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.Trays.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.TrayHeight_inch.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.TrayWidth_inch.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.Handed.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.Power.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.PowerConsumption.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                             ||  z.Format.ToLower().Contains(param.sSearch.ToLower()) );

            switch (sortColumnIndex)
            {
                case 1:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.AssetCategory) : viewModel.OrderByDescending(z => z.AssetCategory);
                    break;
                case 2:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.AssetType) : viewModel.OrderByDescending(z => z.AssetType);
                    break;
                case 3:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.ControllerType) : viewModel.OrderByDescending(z => z.ControllerType);
                    break;
                case 4:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Controllers) : viewModel.OrderByDescending(z => z.Controllers);
                    break;
                case 5:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Trays) : viewModel.OrderByDescending(z => z.Trays);                  
                    break;
                case 6:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.TrayHeight_inch + " " + z.TrayWidth_inch) : viewModel.OrderByDescending(z => z.TrayHeight_inch + " " + z.TrayWidth_inch);
                    break;
                case 7:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Handed ) : viewModel.OrderByDescending(z => z.Handed);
                    break;
                case 8:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Format): viewModel.OrderByDescending(z => z.Format);
                    break;
                case 9:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Power) : viewModel.OrderByDescending(z => z.Power);
                    break;
                case 10:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.PowerConsumption) : viewModel.OrderByDescending(z => z.PowerConsumption);
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
                iTotalRecords = totalviewModel,
                iTotalDisplayRecords = filteredviewModelCount,
                aaData = viewModel
            });
        }


        // GET: Asset/Details/5
        public async Task<IActionResult> AssetDetails(int? id)
        {
            if (id == null)
            {
                return RedirectToPage("Home/Notfound");
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
            List<AssetTypeMaster> AType = new List<AssetTypeMaster>();
            List<ControllerTypeMaster> CType = new List<ControllerTypeMaster>();
            Category = (from lists in _context.AssetCategory select lists).ToList();
            AType = (from lists in _context.AssetType select lists).ToList();
            CType = (from lists in _context.ControllerType select lists).ToList();
            Category.Insert(0, new AssetCategoryMaster { Id= 0, AssetCategory = "---Select---" });
            AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---" });
            CType.Insert(0, new ControllerTypeMaster { Id = 0, ControllerType = "---Select---" });
            ViewBag.ACateogies = Category;
            ViewBag.ATypes = AType;
            ViewBag.CTypes = CType;
            return View();
        }

        // POST: Asset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsset([Bind("Id,AssetCategory,AssetType,ControllerType,Controllers,Trays,TrayHeight_inch,TrayWidth_inch,Handed,Format,Power,PowerConsumption")] AssetMaster assetMaster)
        {
            if (ModelState.IsValid)
            {               
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
            List<AssetTypeMaster> AType = new List<AssetTypeMaster>();
            List<ControllerTypeMaster> CType = new List<ControllerTypeMaster>();
            Category = (from lists in _context.AssetCategory select lists).ToList();
            AType = (from lists in _context.AssetType select lists).ToList();
            CType = (from lists in _context.ControllerType select lists).ToList();
            Category.Insert(0, new AssetCategoryMaster { Id = 0, AssetCategory = "---Select---" });
            AType.Insert(0, new AssetTypeMaster { Id = 0, AssetType = "---Select---" });
            CType.Insert(0, new ControllerTypeMaster { Id = 0, ControllerType = "---Select---" });
            ViewBag.ACateogiesedit = Category;
            ViewBag.ATypesedit = AType;
            ViewBag.CTypesedit = CType;
            return View(assetMaster);
        }

        // POST: Asset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsset(int id, [Bind("Id,AssetCategory,AssetType,ControllerType,Controllers,Trays,TrayHeight_inch,TrayWidth_inch,Handed,Format,Power,PowerConsumption")] AssetMaster assetMaster)
        {
            if (id != assetMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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

        private bool AssetMasterExists(int id)
        {
            return _context.Assets.Any(e => e.Id == id);
        }
    }
}
