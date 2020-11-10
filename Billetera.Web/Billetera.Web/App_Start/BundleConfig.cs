using System.Web.Optimization;

namespace Billetera.Web.App_Start
{

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/Bundles").Include(
            "~/bundles/inline.*",
            "~/bundles/polyfills.*",
            "~/bundles/scripts.*",
            "~/bundles/vendor.*",
            "~/bundles/runtime.*",
            "~/bundles/zone.*",
            "~/bundles/main.*"));
            bundles.Add(new StyleBundle("~/Content/Styles").Include("~/bundles/styles.*"));
        }
    }
}