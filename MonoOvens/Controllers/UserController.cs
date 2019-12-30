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
            //var query=  from q in _context.Users u join RoleManager<IdentityRole> r on 
            //            select
            // var UserInRole = _context.Users.
            //Join(_roleManager, u => u.Id, uir => uir.UserId,
            //(u, uir) => new { u, uir }).
            //Join(_roleManager, r => r.uir.RoleId, ro => ro.RoleId, (r, ro) => new { r, ro })

            //.Select(m => new 
            //{
            //    UserName = m.r.u.FirstName,
            //    RoleName = m.ro.Name
            //});
            //var userRole = "";
            ////if (User.IsInRole("Administrator"))
            ////{
            ////    userRole = "Admin";
            ////}
            
           // return View(viewModel);
            return View(await _context.Users.ToListAsync());

        }


        //data provider method for the Users list.
        public JsonResult UserAjaxDataProvider(GridPagination param)
        {
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
         //   IEnumerable<UserMaster> Users = _context.Users;

            var viewModel = from pd in _context.Users
                            join p in _roleManager.Roles on pd.AccessRole equals p.Id
                            where pd.AccessRole == p.Id 
                            where pd.IsDeleted == false
                            select new
                            {
                                //Id = _context.Users.Select(x => x.Id),
                                //Name = _context.Users.Select(x => x.FirstName) + " " + _context.Users.Select(x => x.LastName),
                                //Email = _context.Users.Select(x => x.Email),
                                //Role = _roleManager.Roles.Where(x => x.Id == pd.AccessRole).Select(x => x.Name)
                                Id = pd.Id,
                                Name = pd.FirstName + " " + pd.LastName,
                                Email = pd.Email,
                                Role = p.Name
                            };

            // var totalUsers = _context.Users.Count();
            var totalUsers = viewModel.ToList().Count();
             var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) viewModel = viewModel.Where(z => z.Role.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Email.ToString().ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Name.ToLower().Contains(param.sSearch.ToLower())   );

            switch (sortColumnIndex)
            {
                case 1:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Name ) : viewModel.OrderByDescending(z => z.Name);
                    break;
                case 2:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Email) : viewModel.OrderByDescending(z => z.Email);
                    break;
                case 3:
                    viewModel = sortDirection == "asc" ? viewModel.OrderBy(z => z.Role) : viewModel.OrderByDescending(z => z.Role);
                    break;

                default:
                    viewModel = viewModel.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredUsersCount = viewModel.Count();
            viewModel = viewModel.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                //   iTotalRecords = totalUsers,
                iTotalRecords = filteredUsersCount,
                iTotalDisplayRecords = filteredUsersCount,
                aaData = viewModel
            });
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
                var user = _userManager.GetUserId(User);
                //       var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                userMaster.CreatedBy = userName;
                // _context.Add(userMaster);
                userMaster.UserName = userMaster.Email;
                var rolename = _roleManager.Roles.Where(e=>e.Id == userMaster.AccessRole).Select(e=>e.Name).FirstOrDefault();
               // userMaster.AccessRole = rolename;
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
                    var user = _userManager.GetUserId(User);
                    // var userName = _context.Users.Where(x => x.Id == user).Select(x => x.FirstName + " " + x.LastName).FirstOrDefault();
                    var userName = _context.Users.Where(x => x.Id == user).Select(x => x.Id).FirstOrDefault();
                    userMaster.ModifiedBy = userName;

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


        //To soft delete a record.
        public JsonResult Delete(string id)
        {
            if (id == null)
            {
                return Json(new
                {
                    success = 0
                });
                //return RedirectToAction("NotFound", "Home");
            }
            var user = _context.Users.Find(id);
            //  _context.Customers.Remove(customer);
            if (user.IsDeleted == false)
            {
                user.IsDeleted = true;   // flag for a soft delete is set.
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
        //// GET: User/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var userMaster = await _context.Users
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (userMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(userMaster);
        //}

        //// POST: User/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<JsonResult> DeleteConfirmed(string id)
        //{
        //    var userMaster = await _context.Users.FindAsync(id);
        //    _context.Users.Remove(userMaster);
        //    await _context.SaveChangesAsync();
        //    return Json(new
        //    {
        //        success = 1
        //    });
        //}
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var userMaster = await _context.Users.FindAsync(id);
        //    _context.Users.Remove(userMaster);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(UsersList));
        //}

        private bool UserMasterExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
