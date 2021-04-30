using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Practice_8.Models;
using System;
using System.Linq;

namespace Practice_8.Helper
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
                        Name = "Student",
                    };
                    IdentityRole roleTeacher = new IdentityRole()
                    {
                        Name = "Teacher",
                    };
                    roleManager.Create(roleAdmin);
                    roleManager.Create(roleUser);
                    roleManager.Create(roleTeacher);
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