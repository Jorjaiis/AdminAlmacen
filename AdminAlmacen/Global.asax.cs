using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AdminAlmacen.App_Start;
using AdminAlmacen.Security;

namespace AdminAlmacen
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Register WEB API
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAuthenticateRequest()
        {
            if (Request.IsAuthenticated)
            {
                var identity = new PersonalizedIdentity(HttpContext.Current.User.Identity);
                var principal = new PrincipalPersonalizado(identity);
                HttpContext.Current.User = principal;
            }
        }
    }
}
