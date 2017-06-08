using System.Web;
using System.Web.Optimization;

namespace YouthInitiative
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)

        {
            bundles.Add(new ScriptBundle("~/bundles/YouthInitiative")
        .IncludeDirectory("~/Scripts/Controllers", "*.js")
        .Include("~/Scripts/YouthInitiative.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
