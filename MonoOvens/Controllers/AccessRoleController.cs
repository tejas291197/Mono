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
    public class AccessRoleController : Controller
    {
        private readonly MonoContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccessRoleController(MonoContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        // GET: AccessRole
        public async Task<IActionResult> Index()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }

        // GET: AccessRole/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleMaster == null)
            {
                return NotFound();
            }

            return View(roleMaster);
        }

        // GET: AccessRole/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccessRole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( RoleMaster roleMaster)
        {
            if (ModelState.IsValid)
            {
                IdentityResult roleResult;


                var roleExist = await _roleManager.RoleExistsAsync(roleMaster.Name);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1  
                    roleResult = await _roleManager.CreateAsync(new IdentityRole(roleMaster.Name));
                }
                //_context.Add(roleMaster);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roleMaster);
        }

        // GET: AccessRole/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster.FindAsync(id);
            if (roleMaster == null)
            {
                return NotFound();
            }
            return View(roleMaster);
        }

        // POST: AccessRole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,NormalizedName,ConcurrencyStamp")] RoleMaster roleMaster)
        {
            if (id != roleMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleMasterExists(roleMaster.Id))
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
            return View(roleMaster);
        }

        // GET: AccessRole/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleMaster = await _context.RoleMaster
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roleMaster == null)
            {
                return NotFound();
            }

            return View(roleMaster);
        }

        // POST: AccessRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var roleMaster = await _context.RoleMaster.FindAsync(id);
            _context.RoleMaster.Remove(roleMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleMasterExists(string id)
        {
            return _context.RoleMaster.Any(e => e.Id == id);
        }
    }
}
