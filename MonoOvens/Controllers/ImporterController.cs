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
    public class ImporterController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public ImporterController(MonoContext context, UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Importer
        public async Task<IActionResult> ImporterList()
        {
            return View(await _context.Importers.ToListAsync());
        }
        public JsonResult ImporterAjaxDataProvider(GridPagination param)
        {

            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            IEnumerable<ImporterMaster> Importers = _context.Importers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalImporters = _context.Importers.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) Importers = Importers.Where(z => z.ImporterName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.ImporterPhone.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.ImporterRegion.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Email.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Region.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Area.ToString().ToLower().Contains(param.sSearch.ToLower()));

            switch (sortColumnIndex)
            {
                case 1:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.ImporterName) : Importers.OrderByDescending(z => z.ImporterName);
                    break;
                case 2:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.ImporterPhone) : Importers.OrderByDescending(z => z.ImporterPhone);
                    break;
                case 3:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.ImporterRegion) : Importers.OrderByDescending(z => z.ImporterRegion);
                    break;
                case 5:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.Email) : Importers.OrderByDescending(z => z.Email);
                    break;
                case 6:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.Region) : Importers.OrderByDescending(z => z.Region);
                    break;
                case 7:
                    Importers = sortDirection == "asc" ? Importers.OrderBy(z => z.Area) : Importers.OrderByDescending(z => z.Area);
                    break;
                default:
                    Importers = Importers.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredImportersCount = Importers.Count();
            Importers = Importers.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalImporters,
               // iTotalRecords = totalImporters,
                iTotalDisplayRecords = filteredImportersCount,
                aaData = Importers
            });
        }

        // GET: ImporterMasters/Details/5
        public async Task<IActionResult> ImporterDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importerMaster = await _context.Importers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (importerMaster == null)
            {
                return NotFound();
            }

            return View(importerMaster);
        }

        // GET: Importer/Create
        public IActionResult CreateImporter()
        {
            return View();
        }

        // POST: ImporterMasters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateImporter([Bind("Id,ImporterName,ImporterPhone,ImporterRegion,Email,Region,Area,IsDeleted,CreatedBy")] ImporterMaster importerMaster)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserId(User);
                //var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                importerMaster.CreatedBy = userName;
                _context.Add(importerMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ImporterList));
            }
            return View(importerMaster);
        }

        // GET: Importer/Edit/5
        public async Task<IActionResult> EditImporter(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importerMaster = await _context.Importers.FindAsync(id);
            if (importerMaster == null)
            {
                return NotFound();
            }
            return View(importerMaster);
        }

        // POST: ImporterMasters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditImporter(int id, [Bind("Id,ImporterName,ImporterPhone,ImporterRegion,Email,Region,Area,IsDeleted,CreatedBy")] ImporterMaster importerMaster)
        {
            if (id != importerMaster.Id)
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
                    importerMaster.ModifiedBy = userName;
                    _context.Update(importerMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImporterMasterExists(importerMaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ImporterList));
            }
            return View(importerMaster);
        }

        private bool ImporterMasterExists(int id)
        {
            throw new NotImplementedException();
        }

        // GET: ImporterMasters/Delete/5
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
            var Importers = _context.Importers.Find(id);
            //  _context.Customers.Remove(customer);
            if (Importers.IsDeleted == false)
            {
                Importers.IsDeleted = true;   // flag for a soft delete is set.
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
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var importerMaster = await _context.Importers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (importerMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(importerMaster);
        //}

        // POST: ImporterMasters/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var importerMaster = await _context.Importers.FindAsync(id);
        //        _context.Importers.Remove(importerMaster);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(ImporterList));
        //    }

        //    private bool ImporterMasterExists(int id)
        //    {
        //        return _context.Importers.Any(e => e.Id == id);
        //    }



    }
}