using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhaleModels;
using WhaleDL;

namespace WhaleBL
{
    public class WhaleBL : IWhaleBL
    {
        private IWhaleRepoDB _repo;
        public WhaleBL(IWhaleRepoDB repo)
        {
            _repo = repo;
        }

    }
}