using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public  class Fichario
    {
        public int FicharioId { get; set; }

        public string Nome { get; set; }

        public ICollection<Pessoa> ListaDePessoa { get; set; } = new List<Pessoa>();

        public Fichario()
        {

        }

        public Fichario(int id, string name)
        {
            FicharioId = id;
            Nome = name;
        }

        public void AddPessoa(Pessoa registrar)
        {
            ListaDePessoa.Add(registrar);
        }
        public void RemovePessoa(Pessoa registrar)
        {
            ListaDePessoa.Remove(registrar);
        }

        public double TotalDeDizimos(DateTime inicial, DateTime final)
        {
            return ListaDePessoa.Sum(pessoa => pessoa.TotalDeDizimos(inicial, final));
        }

    }
}
