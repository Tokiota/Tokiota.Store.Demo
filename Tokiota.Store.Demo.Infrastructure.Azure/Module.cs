namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using ServiceStack.Redis;
    using System.Configuration;

    internal class Module : IModule
    {
        private const string RedisConnectionString = "redis:ConnectionString";

        public void Register(IBuilder builder)
        {
            builder.RegisterAsSingleInstance<ITracer, Tracer>();
            builder.RegisterAsSingleInstance<ICache, Cache>();
            builder.RegisterAsSingleInstance<IFileManager, FileManager>();

            var redisConnectionString = ConfigurationManager.ConnectionStrings[RedisConnectionString].ConnectionString;
            builder.RegisterAsSingleInstance<IRedisClientsManager>(new PooledRedisClientManager(redisConnectionString));
        }
    }
}
