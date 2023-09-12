using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // PROPRIETA':
        public int Codice { get; set; } = new Random().Next(0001, 9999);
        private string Nome { get; set; }
        private string Descrizione { get; set; }
        private decimal Prezzo { get; set; }
        private decimal Iva { get; set; }

        // COSTRUTTORE
        public Prodotto(string codice, string nome, string descrizione, decimal prezzo, decimal iva)
        {
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        // GETTER

        public int codice
        {
            get { return Codice; }
        }
        public string nome
        {
            get { return Nome; }
        }
        public string descrizione
        {
            get { return Descrizione; }
        }
        public string codiceNome
        {
            get { return Codice + Descrizione; }
        }
        public decimal prezzo
        {
            get { return Prezzo; }
        }
        public decimal prezzoConIva
        {
            get { return Prezzo + (Prezzo / 100 * Iva); }
        }
        public decimal iva
        {
            get
            {
                return (prezzo / 100 * Iva);
            }
        }
    }
}
