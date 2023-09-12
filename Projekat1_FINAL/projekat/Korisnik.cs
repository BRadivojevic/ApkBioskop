using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    public enum Pol { Musko, Zensko };

    [Serializable]
    public class Korisnik
    {
        public string ime;
        public string prezime;
        public DateTime datum_rodjenja;
        public string telefon;
        public Pol pol;

        public Korisnik(string ime, string prezime, DateTime datum_rodjenja, string telefon, Pol pol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datum_rodjenja = datum_rodjenja;
            this.telefon = telefon;
            this.pol = pol;
        }
    }
}
