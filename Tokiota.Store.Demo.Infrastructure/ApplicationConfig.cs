namespace Tokiota.Store.Demo.Infrastructure
{
    public static class ApplicationConfig
    {
        private static IContainer container;
        public static void Register(IBootstrapper bootstrapper, params string[] assemblynames)
        {
            container = bootstrapper.Run(assemblynames);
        }

        public static TInterface Resolve<TInterface>()
        {
            return container.Resolve<TInterface>();
        }
    }
}
