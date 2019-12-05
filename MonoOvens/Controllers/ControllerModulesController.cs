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
                case 14:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Elements) : Controllers.OrderByDescending(z => z.Elements);
                    break;
                case 15:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Element) : Controllers.OrderByDescending(z => z.kWh_Rating_Element);
                    break;
                case 16:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.LightType) : Controllers.OrderByDescending(z => z.LightType);
                    break;
                case 17:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Lights) : Controllers.OrderByDescending(z => z.Lights);
                    break;
                case 18:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Light) : Controllers.OrderByDescending(z => z.kWh_Rating_Light);
                    break;
                case 19:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Fans) : Controllers.OrderByDescending(z => z.Fans);
                    break;
                case 20:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Fan) : Controllers.OrderByDescending(z => z.kWh_Rating_Fan);
                    break;
                case 21:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Damper) : Controllers.OrderByDescending(z => z.kWh_Rating_Damper);
                    break;
                case 22:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_WaterSolenoid) : Controllers.OrderByDescending(z => z.kWh_Rating_WaterSolenoid);
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
            //return Json(new
            //{
            //    success = 1
            //});
        }


        //data provider method for the controller list.
        public JsonResult ControllerAjaxDataProvider(GridPagination param)
        {   
            // Thread.Sleep(7000);
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
                                                                                        || z.Wallpaper.ToLower().Contains(param.sSearch.ToLower()) );


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
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Status) : Controllers.OrderByDescending(z => z.Status );
                    break;
                case 13:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.RemoteKill) : Controllers.OrderByDescending(z => z.RemoteKill);
                    break;
                case 14:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Elements) : Controllers.OrderByDescending(z => z.Elements);
                    break;
                case 15:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Element) : Controllers.OrderByDescending(z => z.kWh_Rating_Element);
                    break;
                case 16:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.LightType) : Controllers.OrderByDescending(z => z.LightType);
                    break;
                case 17:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Lights) : Controllers.OrderByDescending(z => z.Lights);
                    break;
                case 18:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Light) : Controllers.OrderByDescending(z => z.kWh_Rating_Light);
                    break;
                case 19:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.Fans) : Controllers.OrderByDescending(z => z.Fans);
                    break;
                case 20:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Fan) : Controllers.OrderByDescending(z => z.kWh_Rating_Fan);
                    break;
                case 21:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_Damper) : Controllers.OrderByDescending(z => z.kWh_Rating_Damper);
                    break;
                case 22:
                    Controllers = sortDirection == "asc" ? Controllers.OrderBy(z => z.kWh_Rating_WaterSolenoid) : Controllers.OrderByDescending(z => z.kWh_Rating_WaterSolenoid);
                    break;
                default:
                    Controllers = Controllers.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredControllersCount = Controllers.Count();
            Controllers = Controllers.Skip(param.iDisplayStart).Take(param.iDisplayLength);

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
            return View();
        }

        // POST: ControllerModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateController([Bind("Id,FG_Code,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins,Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status," +
            "RemoteKill,Elements,kWh_Rating_Element,LightType,Lights,kWh_Rating_Light,Fans,kWh_Rating_Fan,kWh_Rating_Damper,kWh_Rating_WaterSolenoid,IsDeleted")] ControllerModule controllerModule)
        {
            if (ModelState.IsValid)
            {
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
            return View(controllerModule);
        }

        // POST: ControllerModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditController(int id, [Bind("Id,FG_Code,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins,Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status" +
            "RemoteKill,Elements,kWh_Rating_Element,LightType,Lights,kWh_Rating_Light,Fans,kWh_Rating_Fan,kWh_Rating_Damper,kWh_Rating_WaterSolenoid,IsDeleted")] ControllerModule controllerModule)
        {
            if (id != controllerModule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
