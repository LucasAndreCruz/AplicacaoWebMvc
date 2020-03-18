using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Data
{
    public class SeedingService
    {
        private AplicacaoWebMvcContext _context;

        public SeedingService(AplicacaoWebMvcContext context)
        {
            _context = context;
        }

    }
}
