using AplicacaoWebMvc.Data;
using AplicacaoWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace AplicacaoWebMvc.Services
{
    public class ServicoPessoas
    {
        
        // Dependencia ao DbContext 
        private readonly AplicacaoWebMvcContext _context;


        // Construtor para a dependencia acontecer
        public ServicoPessoas(AplicacaoWebMvcContext context)
        {

            _context = context;

        }


        // Retorna uma lista assincrona com todos os dizimistas do banco de dados
        public List<Pessoa> FindAll()
        {
            return _context.Pessoa.ToList();
        }

        // Inserir pessoas no banco de dados
        public void Insert (Pessoa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
