using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public class Contato
    {

        public int ContatoId { get; set; }

        [Display(Name = "Telefone Fixo")]
        public string TelefoneFixo { get; set; }

        [Display(Name = "Telefone Movel")]
        public string TelefoneMovel { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public Contato()
        {
        }

        public Contato(int contatoId, string telefoneFixo, string telefoneMovel, string email, int pessoaId, Pessoa pessoa)
        {
            ContatoId = contatoId;
            TelefoneFixo = telefoneFixo;
            TelefoneMovel = telefoneMovel;
            Email = email;
            PessoaId = pessoaId;
            Pessoa = pessoa;
        }
    }
}
