using System.Web.Optimization;

namespace PeopleSearch
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/angular.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css", 
                "~/Content/Loader.css"));
        }
    }
}