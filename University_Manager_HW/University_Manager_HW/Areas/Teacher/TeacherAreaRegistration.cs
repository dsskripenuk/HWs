using System.Web.Mvc;

namespace University_Manager_HW.Areas.Teacher
{
    public class TeacherAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Teacher";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Teacher_default",
                "Teacher/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
