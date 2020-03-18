using AplicacaoWebMvc.Models.Enums;
using System;

namespace AplicacaoWebMvc.Models
{
    public class RegistroDeDizimo
    {
        public int RegistroDeDizimoId { get; set; }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public StatusDizimista Status { get; set; }

        public Pessoa Pessoa { get; set; }

        public RegistroDeDizimo()
        {
        }

        public RegistroDeDizimo(int registroDeDizimoId, DateTime data, double valor, StatusDizimista status, Pessoa pessoa)
        {
            RegistroDeDizimoId = registroDeDizimoId;
            Data = data;
            Valor = valor;
            Status = status;
            Pessoa = pessoa;
        }
    }
}
