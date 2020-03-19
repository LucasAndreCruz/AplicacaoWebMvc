using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public class Dependente
    {
        public int DependeteId { get; set; }

        [Display(Name = "Nome do Dependente")]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }
        public ICollection<Pessoa> listaDePessoa { get; set; } = new List<Pessoa>();

    }
}
