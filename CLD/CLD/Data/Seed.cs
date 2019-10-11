using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLD.Data
{
    public class Seed
    {
        
            public static void SeedUser(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
            {
                if (roleManager.FindByNameAsync("Admin").Result == null)
                {
                    IdentityRole role = new IdentityRole { Name = "Admin" };
                    roleManager.CreateAsync(role).Wait();

                }
                if (userManager.FindByEmailAsync("admin@admin.com").Result == null)
                {
                    IdentityUser user = new IdentityUser
                    {
                        UserName = "admin@admin.com",
                        Email = "admin@admin.com"
                    };


                    IdentityResult result = userManager.CreateAsync(user, "Password123!").Result;
                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();

                    }
                }
            }
        
    }
}
