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
    public class ClientsController : Controller
    {
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;

        public ClientsController(MonoContext context , UserManager<UserMaster> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Clients
        public async Task<IActionResult> ClientsList()
        {
            return View(await _context.Client.ToListAsync());
        }


        //data provider method for the clients list.
        public JsonResult ClientAjaxDataProvider(GridPagination param)
        {
            // Thread.Sleep(7000);
            var userId = _userManager.GetUserId(User);
            var uId = _context.Users.Where(x => x.Id == userId);
           // IEnumerable<ClientMaster> Clients = _context.Client;
            IEnumerable<ClientMaster> Clients = _context.Client.Where(x => x.IsDeleted == false).OrderByDescending(x => x.Id);
            var totalClients = _context.Client.Count();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(param);
            var sortDirection = HttpContext.Request.Query["sSortDir_0"]; // asc or desc
            var sortColumnIndex = Convert.ToInt32(HttpContext.Request.Query["iSortCol_0"]);
            if (!string.IsNullOrEmpty(param.sSearch)) Clients = Clients.Where(z => z.Area.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.ClientAccountNo.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.City.ToLower().Contains(param.sSearch.ToLower())
                                                                                || z.ClientName.ToLower().Contains(param.sSearch.ToLower())
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
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.ClientAccountNo) : Clients.OrderByDescending(z => z.ClientAccountNo);
                    break;
                case 2:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.ClientName) : Clients.OrderByDescending(z => z.ClientName);
                    break;
                case 3:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.PrimaryEmail) : Clients.OrderByDescending(z => z.PrimaryEmail);
                    break;
                case 4:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.PrimaryContactName) : Clients.OrderByDescending(z => z.PrimaryContactName);
                    break;
                case 5:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.PrimaryContactNumber) : Clients.OrderByDescending(z => z.PrimaryContactNumber);
                    break;
                case 6:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.HOAddress1 + " " + z.HOAddress2+" "+z.HOAddress3+" "+z.City+" "+z.Postcode) : Clients.OrderByDescending(z => z.HOAddress1 + " " + z.HOAddress2 + " " + z.HOAddress3 + " " + z.City + " " + z.Postcode);                    
                    break;
                case 7:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.Country) : Clients.OrderByDescending(z => z.Country);
                    break;
                case 8:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.Region) : Clients.OrderByDescending(z => z.Region);
                    break;
                case 9:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.Area) : Clients.OrderByDescending(z => z.Area);
                    break;
                case 10:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.StoreCode) : Clients.OrderByDescending(z => z.StoreCode);
                    break;
                case 11:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.Type) : Clients.OrderByDescending(z => z.Type);
                    break;
                case 12:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.StoreName) : Clients.OrderByDescending(z => z.StoreName);
                    break;
                case 13:
                    Clients = sortDirection == "asc" ? Clients.OrderBy(z => z.StoreAddress1 + " " + z.StoreAddress2 + " " + z.StoreCode + " " + z.PostTown + " " + z.StorePostcode) : Clients.OrderByDescending(z => z.StoreAddress1 + " " + z.StoreAddress2 + " " + z.StoreCode + " " + z.PostTown + " " + z.StorePostcode);
                    break;

                default:
                    Clients = Clients.OrderByDescending(z => z.Id);
                    break;
            }
            var filteredClientsCount = Clients.Count();
            Clients = Clients.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = filteredClientsCount,
                iTotalDisplayRecords = filteredClientsCount,
                aaData = Clients
            });
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> ClientDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult CreateClient()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClient([Bind("Id,ClientAccountNo,ClientName,PrimaryEmail,PrimaryContactName,PrimaryContactNumber,HOAddress1,HOAddress2,HOAddress3,City,Postcode,Country,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode")] ClientMaster client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ClientsList));
            }
            return View(client);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> EditClient(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditClient(int id, [Bind("Id,ClientAccountNo,ClientName,PrimaryEmail,PrimaryContactName,PrimaryContactNumber,HOAddress1,HOAddress2,HOAddress3,City,Postcode,Country,Region,Area,StoreCode,Type,StoreName,StoreAddress1,StoreAddress2,PostTown,StorePostcode")] ClientMaster client)
        {
            if (id != client.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ClientsList));
            }
            return View(client);
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
            var client = _context.Client.Find(id);
            //  _context.Customers.Remove(customer);
            if (client.IsDeleted == false)
            {
                client.IsDeleted = true;   // flag for a soft delete is set.
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
        // GET: Clients/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var client = await _context.Client
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (client == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(client);
        //}



        // POST: Clients/Delete/5
        //[HttpPost, ActionName("Delete")]
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
        //        var client = await _context.Client.FindAsync(id);
        //        _context.Client.Remove(client);
        //        await _context.SaveChangesAsync();
        //        return Json(new
        //        {
        //            success = 1
        //        });
        //    }

        //}

        //// POST: Clients/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var client = await _context.Client.FindAsync(id);
        //    _context.Client.Remove(client);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(ClientsList));
        //}

        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.Id == id);
        }
    }
}
