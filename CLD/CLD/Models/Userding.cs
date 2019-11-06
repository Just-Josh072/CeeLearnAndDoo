using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class Userding : IdentityUser
    {
        public string Username { get; set; }
        


    }
}
