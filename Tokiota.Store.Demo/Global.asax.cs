namespace Tokiota.Store.Demo
{
    using Infrastructure;
    using Infrastructure.InversionOfControl;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ApplicationConfig.Register(new Bootstrapper(), "Tokiota.Store.Demo", "Tokiota.Store.Demo.Domain.Catalog", "Tokiota.Store.Demo.Domain.Identity", "Tokiota.Store.Demo.Infrastructure.OnPremises");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
