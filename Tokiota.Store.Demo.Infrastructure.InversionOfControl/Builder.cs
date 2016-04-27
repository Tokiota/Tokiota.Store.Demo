namespace Tokiota.Store.Demo.Infrastructure.InversionOfControl
{
    using Autofac;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Web.Mvc;
    internal class Builder : IBuilder
    {
        private ContainerBuilder builder;

        public Builder()
        {
            this.builder = new ContainerBuilder();
        }

        public void Register<TInterface, TService>() where TService : TInterface
        {
            this.builder.RegisterType<TService>().As<TInterface>();
        }

        public void RegisterAsSingleInstance<TInterface, TService>() where TService : TInterface
        {
            this.builder.RegisterType<TService>().As<TInterface>().SingleInstance();
        }

        public void RegisterAssembly(params string[] assemblyNames)
        {
            foreach (var assemblyPath in assemblyNames)
            {
                var assemblyName = new AssemblyName(assemblyPath);
                var assembly = Assembly.Load(assemblyName);
                this.builder.RegisterAssemblyTypes(assembly).Where(t => typeof(IModule).IsAssignableFrom(t)).As<IModule>().PreserveExistingDefaults();
                this.builder.RegisterAssemblyTypes(assembly).Where(t => typeof(ControllerBase).IsAssignableFrom(t)).AsSelf();
            }
        }

        internal Container Build(out IContainer container)
        {
            container = this.builder.Build();
            this.builder = new ContainerBuilder();

            this.LoadModules(container);
            this.builder.RegisterType<Container>().As<Infrastructure.IContainer>().SingleInstance();
            return this.CreateContainer(container);
        }

        private void LoadModules(IContainer container)
        {
            var modules = container.Resolve<IEnumerable<IModule>>();
            foreach (var module in modules)
            {
                module.Register(this);
            }
        }

        private Container CreateContainer(IContainer innerContainer)
        {
            this.builder.Update(innerContainer);
            var container = innerContainer.Resolve<Infrastructure.IContainer>();
            return (Container)container;
        }
    }
}
