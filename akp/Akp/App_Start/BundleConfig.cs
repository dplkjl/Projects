using System.Web;
using System.Web.Optimization;

namespace Akp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/App.js",
                        "~/Scripts/AppClient.js",
                        "~/Scripts/AppEnrolment.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            //bundles.Add(new StyleBundle("~/Content/css").Include(
            ////          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/normalize.css",
                "~/Content/site.css",
                "~/Content/pure-release-0.5.0/pure-min.css",
                "~/Content/pure-release-0.5.0/base.css",
                "~/Content/pure-release-0.5.0/buttons.css",
                "~/Content/pure-release-0.5.0/forms.css",
                "~/Content/pure-release-0.5.0/grids.css",
                "~/Content/pure-release-0.5.0/menus.css",
                "~/Content/pure-release-0.5.0/side-menu.css"));


            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = false;
        }
    }
}
