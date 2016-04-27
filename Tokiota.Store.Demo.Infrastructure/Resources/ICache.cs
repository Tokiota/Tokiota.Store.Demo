using System;

namespace Tokiota.Store.Demo.Infrastructure
{
    public interface ICache
    {
        T Get<T>(string key);

        T Get<T>(string key, Func<T> getter);

        T Get<T>(string key, Func<T> getter, TimeSpan expire);

        void Set<T>(string key, T value);

        void Set<T>(string key, T value, TimeSpan expire);

        void Set(string key, object value);

        void Set(string key, object value, TimeSpan expire);

        bool Contains(string key);
    }
}
