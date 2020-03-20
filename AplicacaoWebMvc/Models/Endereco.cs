using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Rua/Avenida,N°")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Bairro { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Cidade/UF")]
        public string Cidade { get; set; }


        // Relacionamentos de outra entidade
        public int PessoaId { get; set; }
        public Pessoa pessoa { get; set; }

        public Endereco()
        {
        }

        public Endereco(int enderecoId, string logradouro, string complemento, string bairro, string cidade, string cep, int pessoaId, Pessoa pessoa)
        {
            EnderecoId = enderecoId;
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Cep = cep;
            PessoaId = pessoaId;
            this.pessoa = pessoa;
        }
    }
}
