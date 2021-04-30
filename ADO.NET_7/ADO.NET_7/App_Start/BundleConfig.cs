using System.Web;
using System.Web.Optimization;

namespace ADO.NET_7
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Template").Include(
                "~/Content/Template/bootstrap.min.css",
                "~/Content/Template/animate.min.css",
                "~/Content/Template/jquery-ui.css",
                "~/Content/Template/jquery.mCustomScrollbar.min.css",
                "~/Content/Template/meanmenu.css",
                "~/Content/Template/nice-select.css",
                "~/Content/Template/normalize.css",
                "~/Content/Template/owl.carousel.min.css",
                "~/Content/Template/responsive.css",
                "~/Content/Template/slick.css",
                "~/Content/Template/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/Temp").Include(
                "~/Scripts/Temp/custom.js",
                       "~/Scripts/Temp/jquery-3.0.0.min.js",
                       "~/Scripts/Temp/jquery.mCustomScrollbar.concat.min.js",
                       "~/Scripts/Temp/jquery.min.js",
                       "~/Scripts/Temp/jquery.validate.js",
                       "~/Scripts/Temp/plugin.js",
                       "~/Scripts/Temp/popper.min.js",
                       "~/url/https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"
                ));
        }
    }
}
