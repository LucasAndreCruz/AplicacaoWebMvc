using AplicacaoWebMvc.Data;
using AplicacaoWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Services
{
    public class ServicoFichario
    {
        private readonly AplicacaoWebMvcContext _context;

        public ServicoFichario(AplicacaoWebMvcContext context)
        {

            _context = context;

        }

        // Retornar todos os fichario
        public List<Fichario> FindAll()
        {
            return _context.Fichario.OrderBy(x => x.Nome).ToList();
        }

    }
}
