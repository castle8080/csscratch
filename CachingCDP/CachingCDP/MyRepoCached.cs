using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingCDP
{
    public class MyRepoCached : IMyRepo
    {
        private IMyRepo _sourceRepo;
        private ICache<object> _cache;

        public MyRepoCached(IMyRepo sourceRepo, ICache<object> cache)
        {
            this._sourceRepo = sourceRepo;
            this._cache = cache;
        }

        public Task<string> GetIdentifier(string name)
        {
            return _cache.GetCachedAsync(name, k =>
            {
                return _sourceRepo.GetIdentifier(name);
            });
        }
    }
}
