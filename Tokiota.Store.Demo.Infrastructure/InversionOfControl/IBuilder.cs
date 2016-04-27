namespace Tokiota.Store.Demo.Infrastructure
{
    public interface IBuilder
    {
        void Register<TInterface, TService>() where TService : TInterface;

        void RegisterAsSingleInstance<TInterface, TService>() where TService : TInterface;
    }
}