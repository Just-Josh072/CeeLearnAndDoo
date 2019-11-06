using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Models
{
    public class UserViewModel : IdentityUser
    {
        public User User { get; set; }

        public List<User> Users { get; set; }
    }
}
