using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingCDP
{
    public interface IMyRepo
    {
        public Task<string> GetIdentifier(string name);
    }
}
