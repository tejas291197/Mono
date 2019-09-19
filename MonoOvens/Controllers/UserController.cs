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
    public class UserController : Controller
    {
        private readonly MonoContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<UserMaster> _userManager;

        public UserController(MonoContext context, RoleManager<IdentityRole> roleManager, UserManager<UserMaster> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
          
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userMaster == null)
            {
                return NotFound();
            }

            return View(userMaster);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            //List<IdentityRole> roles = new List<IdentityRole>();
            var rolelist = _roleManager.Roles.ToList();
            rolelist.Insert(0, new IdentityRole { Id = "", Name = "---Select---" });
            ViewBag.AccessRoles = rolelist;
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,Name,Birthdate,Password,Gender,RollId,AddressLine1,AddressLine2,City")] UserMaster userMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userMaster);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.Users.FindAsync(id);
            if (userMaster == null)
            {
                return NotFound();
            }

            var rolelist = _roleManager.Roles.ToList();
            rolelist.Insert(0, new IdentityRole { Id = "", Name = "---Select---" });
            ViewBag.AccessRoles = rolelist;
          
            return View(userMaster);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,EmployeeId,Name,Birthdate,Gender,RollId,AddressLine1,AddressLine2,City")] UserMaster userMaster)
        {
            if (id != userMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserMasterExists(userMaster.Id))
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
            return View(userMaster);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userMaster = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userMaster == null)
            {
                return NotFound();
            }

            return View(userMaster);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var userMaster = await _context.Users.FindAsync(id);
            _context.Users.Remove(userMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserMasterExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
