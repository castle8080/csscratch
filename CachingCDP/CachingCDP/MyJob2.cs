using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingCDP
{
    public class MyJob2
    {
        private IMyRepo _sourceRepo;
        private IMyRepo _cacheRepo;

        public MyJob2(IMyRepo sourceRepo, IMyRepo cacheRepo)
        {
            _sourceRepo = sourceRepo;
            _cacheRepo = cacheRepo;
        }

        public async Task Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("source: " + await _sourceRepo.GetIdentifier("xx"));
                Console.WriteLine("cache: " + await _cacheRepo.GetIdentifier("xx"));
            }
        }
    }
}
