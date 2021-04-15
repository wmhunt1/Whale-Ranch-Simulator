using MixerModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhaleDL
{
    public class WhaleRepoDB : IWhaleRepoDB
    {
        private readonly WhaleDBContext _context;

        public WhaleRepoDB(WhaleDBContext context)
        {
            _context = context;
        }
    }
}