using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Manager_HW.Models;

namespace University_Manager_HW.Helper
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

                IdentityRole roleStudent = new IdentityRole()
                {
                    Name = "Student",
                };

                IdentityRole roleTeacher = new IdentityRole()
                {
                    Name = "Teacher",
                };

                roleManager.Create(roleAdmin);
                roleManager.Create(roleStudent);
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
