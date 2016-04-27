using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tokiota.Store.Demo.Startup))]
namespace Tokiota.Store.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
