using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingCDP
{
    public static class CacheExtensions
    {
        public async static Task<T> GetCachedAsync<K, T>(this ICache<K> cache, K key, Func<K, Task<T>> getter)
        {
            var resultOption = await cache.GetAsync<T>(key);
            return await resultOption.Match(
                Task.FromResult,
                async () =>
                {
                    var result = await getter(key);
                    await cache.PutAsync(key, result);
                    return result;
                }
            );
        }

    }
}
