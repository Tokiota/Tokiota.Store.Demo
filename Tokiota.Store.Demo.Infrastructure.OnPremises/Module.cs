namespace Tokiota.Store.Demo.Infrastructure.OnPremises
{
    internal class Module : IModule
    {
        public void Register(IBuilder builder)
        {
            builder.RegisterAsSingleInstance<ITracer, Tracer>();
            builder.RegisterAsSingleInstance<ICache, Cache>();
            builder.RegisterAsSingleInstance<IFileManager, FileManager>();
        }
    }
}
