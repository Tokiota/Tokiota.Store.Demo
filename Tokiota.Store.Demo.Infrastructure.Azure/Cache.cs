namespace Tokiota.Store.Demo.Infrastructure.Azure
{
    using System;

    public class Cache : ICache
    {
        public bool Contains(string key)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key, Func<T> getter)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key, Func<T> getter, TimeSpan expire)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object value)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object value, TimeSpan expire)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value, TimeSpan expire)
        {
            throw new NotImplementedException();
        }
    }
}
