using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optional;

namespace CachingCDP
{
    public interface ICache<K>
    {
        public Task<Option<T>> GetAsync<T>(K key);

        public Task PutAsync<T>(K key, T item);
    }
}
