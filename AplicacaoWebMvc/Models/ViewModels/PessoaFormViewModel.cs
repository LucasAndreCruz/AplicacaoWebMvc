using AplicacaoWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models.ViewModels
{
    public class PessoaFormViewModel
    {
        public Pessoa Pessoa { get; set; }
        public ICollection<Fichario> Ficharios { get; set; }
    }
}
