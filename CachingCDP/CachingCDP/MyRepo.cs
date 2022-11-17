using System;

namespace CachingCDP
{
    public class MyRepo : IMyRepo
    {
        public Task<string> GetIdentifier(string name)
        {
            return Task.FromResult(Guid.NewGuid().ToString());
        }
    }
}
