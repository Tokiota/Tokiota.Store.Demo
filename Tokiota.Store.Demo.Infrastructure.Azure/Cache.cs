namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using ServiceStack.Redis;
    using System;

    public class Cache : ICache
    {
        private readonly IRedisClientsManager clientManager;

        public Cache(IRedisClientsManager clientManager)
        {
            this.clientManager = clientManager;
        }

        public bool Contains(string key)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                return redis.Get<object>(key) != null;
            }
        }

        public T Get<T>(string key)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                return redis.Get<T>(key);
            }
        }

        public T Get<T>(string key, Func<T> getter)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                var result = redis.Get<T>(key);
                if (result == null)
                {
                    result = getter();
                    redis.Set(key, result);
                }

                return result;
            }
        }

        public T Get<T>(string key, Func<T> getter, TimeSpan expire)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                var result = redis.Get<T>(key);
                if (result == null)
                {
                    result = getter();
                    redis.Set(key, result, expire);
                }

                return result;
            }
        }

        public void Set(string key, object value)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                redis.Set(key, value);
            }
        }

        public void Set(string key, object value, TimeSpan expire)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                redis.Set(key, value, expire);
            }
        }

        public void Set<T>(string key, T value)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                redis.Set(key, value);
            }
        }

        public void Set<T>(string key, T value, TimeSpan expire)
        {
            using (var redis = this.clientManager.GetCacheClient())
            {
                redis.Set(key, value, expire);
            }
        }
    }
}
