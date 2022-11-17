using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingCDP
{
    public class MyJob1
    {
        private IMyRepo repo;

        public MyJob1(IMyRepo repo)
        {
            this.repo = repo;
        }

        public async Task Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(await this.repo.GetIdentifier("x"));
            }
        }
    }
}
