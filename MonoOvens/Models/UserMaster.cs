using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonoOvens.Models
{
    public class UserMaster : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string AccessRole { get; set; }
        //// public int Id { get; set; }
        // public string EmployeeId { get; set; }
        // public string Name { get; set; }
        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        // public DateTime Birthdate { get; set; }
        // public string Email { get; set; }
        //public string Password { get; set; }      
        //public string  Gender { get; set; }
        ////public string  Designation { get; set; }
        //public string  AddressLine1 { get; set; }
        //public string AddressLine2 { get; set; }
        //public string City { get; set; }


    }
}
