using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Market.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //Tukaj dodas nova polja za userja, ki ga dodajas v bazo (LOGIN, REGISTER)
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
