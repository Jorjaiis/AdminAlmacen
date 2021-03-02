using System.Web;
using System.Web.Optimization;

namespace AdminAlmacen
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Content/SharedCss")
                .Include("~/Content/dashboard.css"));

            bundles.Add(new ScriptBundle("~/Content/SharedJs")
                .Include("~/Content/dashboard.js"));

            bundles.Add(new ScriptBundle("~/Content/Layoutjs")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js") 
                .Include("~/Content/js/sb-admin-2.min.js")
                .Include("~/Content/js/vendor/jquery/jquery.min.js")
                .Include("~/Content/js/vendor/bootstrap/js/bootstrap.bundle.min.js")
                .Include("~/Content/js/vendor/jquery-easing/jquery.easing.min.js")
                .Include("~/Content/jscript/Layout.js")
                );
            
            bundles.Add(new StyleBundle("~/Content/Layoutcss")
                .Include("~/Content/css/bootstrap.css")
                .Include("~/Content/css/fontawesome/css/all.min.css")
                .Include("~/Content/sb-admin-2.min.css")
                //.Include("~/Content/Site.css")
                //.Include("~/Content/dashboard.css")
                );

            bundles.Add(new StyleBundle("~/Content/Logincss")
                .Include("~/Content/styles/login.css")
                .Include("~/Content/css/bootstrap.css")
                .Include("~/Content/css/fontawesome/css/all.min.css")
                );

            bundles.Add(new ScriptBundle("~/Content/Loginjs")
               .Include("~/Scripts/jquery-{version}.js")
               .Include("~/Scripts/bootstrap.js")
               .Include("~/Content/js/vendor/jquery/jquery.min.js")
               .Include("~/Content/js/vendor/bootstrap/js/bootstrap.bundle.min.js")
               .Include("~/Content/js/vendor/jquery-easing/jquery.easing.min.js"));


            bundles.Add(new StyleBundle("~/Content/Tablescss")
               .Include("~/Content/vendor/datatables/dataTables.bootstrap4.min.css"));

            bundles.Add(new ScriptBundle("~/Content/Tablesjs")
                .Include("~/Content/vendor/datatables/jquery.dataTables.min.js")
                .Include("~/Content/vendor/datatables/dataTables.bootstrap4.min.js")
                .Include("~/Content/js/vendor/jquery-easing/jquery.easing.min.js")
                .Include("~/Content/js/vendor/jquery/jquery.min.js")
                .Include("~/Content/js/vendor/bootstrap/js/bootstrap.bundle.min.js")
                .Include("~/Content/demo/datatables-demo.js")
                );

            bundles.Add(new ScriptBundle("~/Content/Homejs")
               .Include("~/Content/vendor/chart.js/Chart.js")
               .Include("~/Content/vendor/chart.js/Chart.min.js")
               .Include("~/Content/demo/chart-area-demo.js")
               .Include("~/Content/demo/chart-pie-demo.js"));
            
            //Archivos JS y CSS utlilizados en la vista CreateProvider
            bundles.Add(new ScriptBundle("~/Content/jscript/CreateProvider")
                .Include("~/Content/jscript/CreateProvider.js")
                );


        }
    }
}
