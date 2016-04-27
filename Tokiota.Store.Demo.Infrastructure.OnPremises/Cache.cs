namespace Tokiota.Store.Demo.Infrastructure.OnPremises
{
    using System;
    using System.Web;

    public class Cache : ICache
    {
        public T Get<T>(string key)
        {
            try
            {
                return (T)HttpRuntime.Cache[key];
            }
            catch
            {
                return default(T);
            }
        }

        public T Get<T>(string key, Func<T> getter)
        {
            if (!this.Contains(key))
            {
                this.Set(key, getter());
            }

            return this.Get<T>(key);
        }

        public T Get<T>(string key, Func<T> getter, TimeSpan expire)
        {
            if (!this.Contains(key))
            {
                this.Set(key, getter(), expire);
            }

            return this.Get<T>(key);
        }

        public void Set<T>(string key, T value)
        {
            this.Set(key, (object)value);
        }

        public void Set<T>(string key, T value, TimeSpan expire)
        {
            this.Set(key, (object)value, expire);
        }


        public void Set(string key, object value)
        {
            if (value == null)
            {
                HttpRuntime.Cache.Remove(key);
            }
            else
            {
                HttpRuntime.Cache[key] = value;
            }
        }

        public void Set(string key, object value, TimeSpan expire)
        {
            if (value == null)
            {
                HttpRuntime.Cache.Remove(key);
            }
            else
            {
                HttpRuntime.Cache.Insert(key, value, null, DateTime.Now.Add(expire), TimeSpan.Zero);
            }
        }

        public bool Contains(string key)
        {
            return HttpRuntime.Cache[key] != null;
        }
    }
}
