using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    class Administrator : Korisnik
    {
        public string korisnicko_ime;

        public Administrator(string korisnicko_ime, string ime, string prezime, DateTime datum_rodjenja, string telefon, Pol pol)
            : base(ime, prezime, datum_rodjenja, telefon, pol)
        {
            this.korisnicko_ime = korisnicko_ime;
        }
    }
}
