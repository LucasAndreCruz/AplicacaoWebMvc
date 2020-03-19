using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Numero { get; set; }

        public ICollection<Pessoa> listaDePessoa { get; set; } = new List<Pessoa>();

        public Endereco()
        {
        }

        public Endereco(int enderecoId, string logradouro, string bairro, string cep, string numero)
        {
            EnderecoId = enderecoId;
            Logradouro = logradouro;
            Bairro = bairro;
            Cep = cep;
            Numero = numero;
        }
    }
}
