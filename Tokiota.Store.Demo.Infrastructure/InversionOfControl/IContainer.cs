namespace Tokiota.Store.Demo.Infrastructure
{
    public interface IContainer
    {
        TInterface Resolve<TInterface>();
    }
}
