using System.Web;
using System.Web.Optimization;

namespace FA.JustBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/App_Themes/CleanBlog/vendor/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js_CleanBlog").Include(
                      "~/App_Themes/CleanBlog/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/App_Themes/CleanBlog/js/clean-blog.min.js"));

            bundles.Add(new StyleBundle("~/Style/css_CleanBlog").Include(
                      "~/App_Themes/CleanBlog/vendor/bootstrap/css/bootstrap.min.css",
                      "~/App_Themes/CleanBlog/vendor/fontawesome-free/css/all.min.css",
                      "~/App_Themes/CleanBlog/css/clean-blog.min.css"));
        }
    }
}
