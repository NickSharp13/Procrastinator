using System.Web;
using System.Web.Optimization;

namespace Procrastinator
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/Scripts/jquery-3.4.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsstuff").Include(
                        "~/Scripts/jquery.isotope.min.js",
                        "~/Scripts/wow.min.js",
                        "~/Scripts/animate.js",
                        "~/Scripts/functions.js",
                        "~/Scripts/fancybox/jquery.fancybox.pack.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/isotope.css",                      
                        "~/Scripts/fancybox/jquery.fancybox.css",
                        "~/Content/style.css"));
        }
    }
}
