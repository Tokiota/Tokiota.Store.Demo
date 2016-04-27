namespace Tokiota.Store.Demo.Infrastructure.InversionOfControl
{
    using Autofac;

    internal class Container : Tokiota.Store.Demo.Infrastructure.IContainer
    {
        private readonly ILifetimeScope scope;

        public Container(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public TInterface Resolve<TInterface>()
        {
            return this.scope.Resolve<TInterface>();
        }
    }
}
