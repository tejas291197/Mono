using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MonoOvens.Models;

namespace MonoOvens.Controllers
{
    public class AssetController : Controller
    {
        private readonly MonoContext _context;

        public AssetController(MonoContext context)
        {
            _context = context;
        }

        // GET: Asset
        public async Task<IActionResult> Index()
        {
            return View(await _context.Assets.ToListAsync());
        }

        // GET: Asset/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
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
        public IActionResult Create()
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
        public async Task<IActionResult> Create([Bind("Id,AssetCategory,AssetType,ControllerType,Controllers,Trays,TrayHeight_inch,TrayWidth_inch,Handed,Format,Power,PowerConsumption")] AssetMaster assetMaster)
        {
            if (ModelState.IsValid)
            {
               
                _context.Add(assetMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assetMaster);
        }

        // GET: Asset/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,AssetCategory,AssetType,ControllerType,Controllers,Trays,TrayHeight_inch,TrayWidth_inch,Handed,Format,Power,PowerConsumption")] AssetMaster assetMaster)
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
                return RedirectToAction(nameof(Index));
            }
            return View(assetMaster);
        }

        // GET: Asset/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assetMaster = await _context.Assets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (assetMaster == null)
            {
                return NotFound();
            }

            return View(assetMaster);
        }

        // POST: Asset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assetMaster = await _context.Assets.FindAsync(id);
            _context.Assets.Remove(assetMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssetMasterExists(int id)
        {
            return _context.Assets.Any(e => e.Id == id);
        }
    }
}
