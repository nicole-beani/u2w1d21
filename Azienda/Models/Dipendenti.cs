using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azienda.Models
{
    public class Dipendenti
    {
        public int Id;
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CF { get; set; }
        public bool Coniugato { get; set; }
        public int NumFigli { get; set; }
        public string Mansione { get; set; }

        public Dipendenti() { }
        public Dipendenti(string nome, string cognome, string indirizzo, string cF, bool coniugato, int numFigli, string mansione)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            CF = cF;
            Coniugato = coniugato;
            NumFigli = numFigli;
            Mansione = mansione;
        }
    }
}