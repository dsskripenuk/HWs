using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_Manager_HW.Entity;
using University_Manager_HW.Helper;
using University_Manager_HW.Models;

namespace University_Manager_HW.Areas.Teacher.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeacherPanelController : Controller
    {
        private ApplicationDbContext _context;

        public TeacherPanelController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult TeacherPanel()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddStudentToGroup()
        {
            CreateStudentGroupViewModel model = new CreateStudentGroupViewModel();

            model.Groups = _context.Groups.Select(g => new SelectListItem() { Text = g.Name, Value = g.Id.ToString() }).ToList();
            model.Studetnts = new List<SelectListItem>();

            var role = _context.Roles.FirstOrDefault(r => r.Name == "Student");
            List<ApplicationUser> Users = new List<ApplicationUser>();

            foreach (var item in _context.Users.ToList())
            {
                var roles = item.Roles.ToList();
                if (roles.FirstOrDefault(r => r.RoleId == role.Id) != null)
                    Users.Add(item);
            }

            foreach (var item in Users)
                if (item.StudentGroup == null)
                    model.Studetnts.Add(new SelectListItem { Text = item.UserName, Value = item.Id });

            return View(model);
        }

        [HttpPost]
        public ActionResult AddStudentToGroup(CreateStudentGroupViewModel model)
        {
            _context.studentGroups.Add(new StudentGroup
            {
                Id = model.StudentId,
                GroupId = int.Parse(model.GroupId),
            });

            var group = _context.Groups.FirstOrDefault(g => g.Id == int.Parse(model.GroupId));
            var student = _context.Users.FirstOrDefault(u => u.Id == model.StudentId);

            if (!string.IsNullOrWhiteSpace(group.EducationStartDate))
            {
                var educationStartDate = DateTime.Parse(group.EducationStartDate);
                var currentDate = DateTime.Now;

                if (educationStartDate > currentDate)
                    if (student?.StudentGroup?.GroupId == group.Id)
                    {
                        var startIn7 = educationStartDate.AddDays(-7);
                        var startIn1 = educationStartDate.AddDays(-1);

                        var jobIn7 = BackgroundJob.Schedule(
                            () => SendEmail.SendMail($"{student.UserAdditionalInfo.FullName}\n Group {group.Name} in 1 week lessons start!", student.Email, "dsskripenuc770@gmail.com"),
                            startIn7);

                        var jobIn1 = BackgroundJob.Schedule(
                            () => SendEmail.SendMail($"{student.UserAdditionalInfo.FullName}\n Group {group.Name} in 1 day lessons start!", student.Email, "dsskripenuc770@gmail.com"),
                            startIn1);
                    }
            }
            _context.SaveChanges();

            return RedirectToAction("GroupList", "TeacherPanel");
        }

        public ActionResult GroupList()
        {
            var groups = _context.Groups.Select(s => new GroupViewModel
            {
                Description = s.Description,
                Name = s.Name,
                Id = s.Id
            });

            return View(groups);
        }

        [HttpGet]
        public ActionResult StudentsGroup(int id)
        {
            var role = _context.Roles.FirstOrDefault(r => r.Name == "Student");
            List<ApplicationUser> Users = new List<ApplicationUser>();
            
            foreach (var item in _context.Users.ToList())
            {
                var roles = item.Roles.ToList();
                if (roles.FirstOrDefault(r => r.RoleId == role.Id) != null)
                    Users.Add(item);
            }

            var students = new List<UserViewModel>();
            
            foreach (var item in Users)
            {
                if (item?.StudentGroup?.GroupId == id)
                {
                    students.Add(new UserViewModel { Email = item.Email, FullName = item.UserAdditionalInfo.FullName, Address = item.UserAdditionalInfo.Address });
                }
            }

            return View(students);
        }
    }
}