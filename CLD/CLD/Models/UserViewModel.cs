using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class UserViewModel : ApplicationUser
    {
        public ApplicationUser ApplicationUser { get; set; }

        public List<ApplicationUser> Users { get; set; }
    }
}
