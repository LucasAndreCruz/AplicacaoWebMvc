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


        // Informações Pessoais

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        public Sexo Sexo { get; set; }

        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        public string Conjugue { get; set; }

        [Display(Name = "Cidade de Nascimento/UF")]
        public string CidadeDeNascimento { get; set; }

        public string Nacionalidade { get; set; }

        [Display(Name = "Nome do Pai")]
        public string NomeDoPai { get; set; }

        [Display(Name = "Nome da Mãe")]
        public string NomeDaMae { get; set; }


        // Dados de endereço e contatos

        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }

        [Display(Name = "Observações")]
        public string Observacao { get; set; }


        // Relacionamentos 
        public Fichario Fichario { get; set; }
        [Display(Name = "Fichário")]
        public int FicharioId { get; set; }
        public ICollection<RegistroDeDizimo> Registro { get; set; } = new List<RegistroDeDizimo>();
        
        public Pessoa()
        {

        }

        public Pessoa(int pessoaId, string nome, string cPF, DateTime dataDeNascimento, Sexo sexo, EstadoCivil estadoCivil, string conjugue, string cidadeDeNascimento, string nacionalidade, string nomeDoPai, string nomeDaMae, Endereco endereco, Contato contato, string observacao, Fichario fichario, int ficharioId)
        {
            PessoaId = pessoaId;
            Nome = nome;
            CPF = cPF;
            DataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            Conjugue = conjugue;
            CidadeDeNascimento = cidadeDeNascimento;
            Nacionalidade = nacionalidade;
            NomeDoPai = nomeDoPai;
            NomeDaMae = nomeDaMae;
            Endereco = endereco;
            Contato = contato;
            Observacao = observacao;
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

