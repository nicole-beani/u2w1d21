using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azienda.Models
{
    public class PagamentoDipendenti
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Mansione { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public bool Salario { get; set; }
    }
}