namespace Tokiota.Store.Demo.Infrastructure.InversionOfControl
{
    using Autofac.Integration.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    public class Bootstrapper : IBootstrapper
    {
        public Bootstrapper()
        {
        }

        public IContainer Run(IEnumerable<string> modules)
        {
            var builder = new Builder();

            this.LoadModules(builder, modules);

            Autofac.IContainer container;
            var result = builder.Build(out container);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return result;
        }

        private void LoadModules(Builder builder, IEnumerable<string> modules)
        {
            builder.RegisterAssembly(modules.ToArray());
        }
    }
}
