using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class UserMaster : IdentityUser
    {
       // public int Id { get; set; }
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
       // public string Email { get; set; }
        public string Password { get; set; }      
        public string  Gender { get; set; }
        //public string  Designation { get; set; }
        public string  AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string RollId { get; set; }

    }
}
