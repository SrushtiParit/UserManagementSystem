using Login.BLL;
using Login.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Login
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected void Application_Start()
        //{
        //    // Other application initialization code...

        //    // Configure dependency injection
        //    var container = new UnityContainer(); // Use the appropriate container (e.g., Unity, Autofac, etc.)

        //    container.RegisterType<UserManager>();
        //    container.RegisterType<DbUsers>();

        //    DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        //    // Register your routes and other configuration...
        //}

    }
}
