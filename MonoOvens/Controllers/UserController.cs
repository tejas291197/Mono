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
        public async Task<IActionResult> UsersList()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> UserDetails(string id)
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
        public IActionResult CreateUser()
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
        public async Task<IActionResult> CreateUser([Bind("Id,FirstName,LastName,Email,AccessRole")] UserMaster userMaster)
        {
            if (ModelState.IsValid)
            {
                // _context.Add(userMaster);
                userMaster.UserName = userMaster.Email;
                var rolename = _roleManager.Roles.Where(e=>e.Id == userMaster.AccessRole).Select(e=>e.Name).FirstOrDefault();
                var result = await _userManager.CreateAsync(userMaster, "Test@123");
                var roleresult = await _userManager.AddToRoleAsync( userMaster , rolename);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(UsersList));
            }
            return View(userMaster);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> EditUser(string id)
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
        //public async Task<IActionResult> Edit(string id, [Bind("Id,EmployeeId,Name,Birthdate,Email,Gender,RollId,AddressLine1,AddressLine2,City")] UserMaster userMaster)
        //  public ActionResult Edit(string id,[Bind("Id,EmployeeId,Name,Birthdate,Email,Gender,RollId,AddressLine1,AddressLine2,City")] UserMaster userMaster)
        public async Task<IActionResult> EditUser(UserMaster userMaster)
        {
            // if (id != userMaster.Id )
            if(userMaster.Id == null)
            {
                return RedirectToPage("Home/Notfound");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var edituser = _context.Users.FirstOrDefault(x => x.Id == userMaster.Id);
                   
                    edituser.UserName = userMaster.Email;
                    edituser.Email = userMaster.Email;
                    edituser.FirstName = userMaster.FirstName;
                    edituser.LastName = userMaster.LastName;

                    var oldUser = _userManager.FindByIdAsync(userMaster.Id);
                    var oldRoleId = _roleManager.Roles.Where(x => x.Id == edituser.AccessRole).Select(x=>x.Id).FirstOrDefault();
                     var oldRoleName = _context.Roles.SingleOrDefault(r => r.Id == oldRoleId).Name;
                    var newRoleName = _context.Roles.SingleOrDefault(r => r.Id == userMaster.AccessRole).Name;
                    if (oldRoleId != userMaster.AccessRole)
                    {
                        var removeroleresult =  await _userManager.RemoveFromRoleAsync(edituser, oldRoleName);
                        var roleresult = await _userManager.AddToRoleAsync(edituser, newRoleName);
                    }
                    edituser.AccessRole = userMaster.AccessRole;
                    //if (edituser.Email != userMaster.Email)
                    //{
                    //    edituser.Email = userMaster.Email;
                    //    edituser.UserName = userMaster.Email;
                    //    _context.Users.Remove(edituser);
                    //    userMaster.UserName = userMaster.Email;
                    //    _userManager.CreateAsync(userMaster, "Test@123");

                    //}
                    //else
                    //{

                    // }


                    // var removeroleresult = await _userManager.RemoveFromRoleAsync(edituser, edituser.Role);                                       
                    //   _context.Update(userMaster);
                    _context.Entry(edituser).State = EntityState.Modified;
                    //  await _context.SaveChangesAsync();
                    _context.SaveChanges();
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
                return RedirectToAction(nameof(UsersList));
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
            return RedirectToAction(nameof(UsersList));
        }

        private bool UserMasterExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
