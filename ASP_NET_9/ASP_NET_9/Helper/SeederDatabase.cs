using ASP_NET_9.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ASP_NET_9.Helper
{
    public class SeederDatabase
    {
        public static void SeedData()
        {
            var context = new ApplicationDbContext();
            SeedUsers(context);
        }
        private static void SeedUsers(ApplicationDbContext _context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(_context));
            if (!roleManager.Roles.Any())
            {
                IdentityRole roleAdmin = new IdentityRole()
                {
                    Name = "Admin",
                };
                IdentityRole roleUser = new IdentityRole()
                {
                    Name = "User",
                };
                roleManager.Create(roleAdmin);
                roleManager.Create(roleUser);
            }
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(_context));
            if (!userManager.Users.Any())
            {
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                };

                userManager.Create(user, "Qwerty-1");
                userManager.AddToRole(user.Id, "Admin");
            }
        }
    }
}