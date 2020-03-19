using AplicacaoWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebMvc.Models
{
    public class Pessoa
    {
       
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string CPF { get; set; }

        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        public Endereco Endereco { get; set; }
        public Dependente Dependente { get; set; }

        public Fichario Fichario { get; set; }
        [Display(Name = "Fichário")]
        public int FicharioId { get; set; }
        public ICollection<RegistroDeDizimo> Registro { get; set; } = new List<RegistroDeDizimo>();

        public Pessoa()
        {

        }

        public Pessoa(int pessoaId, string nome, string email, DateTime dataDeNascimento, string cPF, EstadoCivil estadoCivil, Endereco endereco, Dependente dependente, Fichario fichario, int ficharioId)
        {
            PessoaId = pessoaId;
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            CPF = cPF;
            EstadoCivil = estadoCivil;
            Endereco = endereco;
            Dependente = dependente;
            Fichario = fichario;
            FicharioId = ficharioId;
        }

        public void AddRegistro(RegistroDeDizimo registrar)
        {
            Registro.Add(registrar);
        }

        public void RemoveRegistro(RegistroDeDizimo registrar)
        {
            Registro.Remove(registrar);
        }

        public double TotalDeDizimos(DateTime inicial, DateTime final)
        {
            return Registro.Where(dizimo => dizimo.Data >= inicial && dizimo.Data <= final).Sum(dizimo => dizimo.Valor);
        }

    }
}

