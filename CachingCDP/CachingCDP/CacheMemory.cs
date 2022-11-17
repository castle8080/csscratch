using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optional;

namespace CachingCDP
{
    public class CacheMemory<K> : ICache<K>
    {
        private IDictionary<K, object> _cache = new Dictionary<K, object>();

        public Task<Option<T>> GetAsync<T>(K key)
        {
            lock(this._cache)
            {
                object value;
                return Task.FromResult(this._cache.TryGetValue(key, out value)
                    ? Option.Some((T) value)
                    : Option.None<T>()
                );
            }
        }

        public Task PutAsync<T>(K key, T item)
        {
            lock (this._cache)
            {
                this._cache[key] = item;
            }
            return Task.CompletedTask;
        }
    }
}
