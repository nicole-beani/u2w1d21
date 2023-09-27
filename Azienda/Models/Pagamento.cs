using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azienda.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public bool Salario { get; set; }

        public int IdDipendenti { get; set; }

        public Pagamento() { }
        public Pagamento(DateTime data, double amount, bool salario, int idDipendenti)
        {
            Data = data;
            Amount = amount;
            Salario = salario;
            IdDipendenti = idDipendenti;
        }
    }
}