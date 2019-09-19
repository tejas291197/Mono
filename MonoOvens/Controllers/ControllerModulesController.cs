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
    public class ControllerModulesController : Controller
    {
        private readonly MonoContext _context;

        public ControllerModulesController(MonoContext context)
        {
            _context = context;
        }

        // GET: ControllerModules
        public async Task<IActionResult> Index()
        {
            return View(await _context.Controller.ToListAsync());
        }

        // GET: ControllerModules/Details/5
        public async Task<IActionResult> Details(int? id)
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
        public IActionResult Create()
        {
            return View();
        }

        // POST: ControllerModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins,Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status")] ControllerModule controllerModule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(controllerModule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(controllerModule);
        }

        // GET: ControllerModules/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,SerialNumber,AuthenticationCode,FirmwareVersion,SoftwareVersion,RecipeVersion,Skins,Wallpaper,SevenDayTimer,SleepDelay,ControllerDate,Status")] ControllerModule controllerModule)
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
                return RedirectToAction(nameof(Index));
            }
            return View(controllerModule);
        }

        // GET: ControllerModules/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: ControllerModules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var controllerModule = await _context.Controller.FindAsync(id);
            _context.Controller.Remove(controllerModule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ControllerModuleExists(int id)
        {
            return _context.Controller.Any(e => e.Id == id);
        }
    }
}
