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
    public class CustomerController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public CustomerController(MonoContext context, UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Customer
        public async Task<IActionResult> CustomersList()
        {
            return View(await _context.Customers.ToListAsync());
        }

        //data provider method for the Users list.
        public JsonResult CustomerAjaxDataProvider(GridPagination param)
        {

            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
            IEnumerable<CustomerMaster> Customers = _context.Customers.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);


            var totalCustomers = Customers.ToList().Count();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
          

            if (!string.IsNullOrEmpty(param.sSearch)) Customers = Customers.Where(z => z.Area.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.City.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.CustomerName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.HOAddress1.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.HOAddress2.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.HOAddress3.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Postcode.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PostTown.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PrimaryContactName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PrimaryContactNumber.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Region.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress1.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreAddress2.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreCode.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StoreName.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.StorePostcode.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Type.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.Country.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.PrimaryEmail.ToLower().Contains(param.sSearch.ToLower()));

            switch (sortColumnIndex)
            {
                case 1:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.CustomerName) : Customers.OrderByDescending(z => z.CustomerName);
                    break;
                case 2:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.PrimaryEmail) : Customers.OrderByDescending(z => z.PrimaryEmail);
                    break;
                case 3:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.PrimaryContactName) : Customers.OrderByDescending(z => z.PrimaryContactName);
                    break;
                case 4:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.PrimaryContactNumber) : Customers.OrderByDescending(z => z.PrimaryContactNumber);
                    break;
                case 5:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.HOAddress1 + " " + z.HOAddress2 + " " + z.HOAddress3 + " " + z.City + " " + z.Postcode) : Customers.OrderByDescending(z => z.HOAddress1 + " " + z.HOAddress2 + " " + z.HOAddress3 + " " + z.City + " " + z.Postcode);
                    break;
                case 6:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.Country) : Customers.OrderByDescending(z => z.Country);
                    break;
                case 7:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.Region) : Customers.OrderByDescending(z => z.Region);
                    break;
                case 8:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.Area) : Customers.OrderByDescending(z => z.Area);
                    break;
                case 9:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.StoreCode) : Customers.OrderByDescending(z => z.StoreCode);
                    break;
                case 10:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.Type) : Customers.OrderByDescending(z => z.Type);
                    break;
                case 11:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.StoreName) : Customers.OrderByDescending(z => z.StoreName);
                    break;
                case 12:
                    Customers = sortDirection == "asc" ? Customers.OrderBy(z => z.StoreAddress1 + " " + z.StoreAddress2 + " " + z.StoreCode + " " + z.PostTown + " " + z.StorePostcode) : Customers.OrderByDescending(z => z.StoreAddress1 + " " + z.StoreAddress2 + " " + z.StoreCode + " " + z.PostTown + " " + z.StorePostcode);
                    break;

                default:
                    Customers = Customers.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredCustomersCount = Customers.Count();
            Customers = Customers.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = totalCustomers,
                iTotalDisplayRecords = filteredCustomersCount,
                aaData = Customers
            });
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> CustomerDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerMaster = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerMaster == null)
            {
                return NotFound();
            }

            return View(customerMaster);
        }

        // GET: Customer/Create
        public IActionResult CreateCustomer()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer([Bind("Id,CustomerName,PrimaryEmail,PrimaryContactName,PrimaryContactNumber,HOAddress1,HOAddress2,HOAddress3,City,Postcode,Country,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode")] CustomerMaster customerMaster)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerMaster);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CustomersList));
            }
            return View(customerMaster);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> EditCustomer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerMaster = await _context.Customers.FindAsync(id);
            if (customerMaster == null)
            {
                return NotFound();
            }
            return View(customerMaster);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(int id, [Bind("Id,CustomerName,PrimaryEmail,PrimaryContactName,PrimaryContactNumber,HOAddress1,HOAddress2,HOAddress3,City,Postcode,Country,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode")] CustomerMaster customerMaster)
        {
            if (id != customerMaster.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerMaster);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerMasterExists(customerMaster.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(CustomersList));
            }
            return View(customerMaster);
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
            var customer = _context.Customers.Find(id);
            //  _context.Customers.Remove(customer);
            if (customer.IsDeleted == false)
            {
                customer.IsDeleted = true;   // flag for a soft delete is set.
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
        // GET: Customer/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customerMaster = await _context.Customers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (customerMaster == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customerMaster);
        //}

        // POST: Customer/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var customerMaster = await _context.Customers.FindAsync(id);
        //    _context.Customers.Remove(customerMaster);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(CustomersList));
        //}

        private bool CustomerMasterExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}