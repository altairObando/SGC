using System.Web;
using System.Web.Optimization;

namespace SGC___Vista
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-1.12.1.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/adminlte").Include(
                "~/Scripts/adminlte.min.js",
                "~/Scripts/sparkline/jquery.sparkline.min.js",
                "~/Scripts/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/Scripts/jvectormap/jquery-jvectormap-world-mill-en.js",
                "~/Scripts/slimScroll/jquery.slimscroll.min.js",
                "~/Scripts/dashboard2.js"
                ));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/themes/base/jquery-ui.min.css",
                      "~/Content/adminlte.min.css"
                      ));
        }
    }
}
