using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    public class Kupac : Korisnik
    {        
        public int id;
        public string korisnicko_ime;
        public string lozinka;

        public Kupac(int id, string korisnicko_ime, string lozinka, string ime, string prezime, DateTime datum_rodjenja, string telefon, Pol pol)
            : base(ime, prezime, datum_rodjenja, telefon, pol)
        {
            this.id = id;
            this.korisnicko_ime = korisnicko_ime;
            this.lozinka = lozinka;
        }

        public override string ToString()
        {
            return $"{id}: '{korisnicko_ime}', {ime} {prezime}, {pol}, tel: {telefon}, dat. rođ: {datum_rodjenja.ToShortDateString()}";
        }

        public string Kratki {
            get => $"{id}, '{korisnicko_ime}', {ime} {prezime}, tel: {telefon}";
        }
    }
}
