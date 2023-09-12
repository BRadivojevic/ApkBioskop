using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    public class Projekcija
    {        
        public int id;
        public DateTime datum_i_vreme_projekcije;
        public int sala;
        public double cena_karte;
        public int film;

        public Projekcija(int id, DateTime datum_i_vreme_projekcije, int sala, double cena_karte, int film)
        {
            this.id = id;
            this.datum_i_vreme_projekcije = datum_i_vreme_projekcije;
            this.sala = sala;
            this.cena_karte = cena_karte;
            this.film = film;
        }

        public override string ToString()
        {
            string naziv_filma = $"{film}";
            foreach (Film film in Program.filmovi)
                if (film.id == this.film)
                    naziv_filma = film.naziv;

            return $"{id}: {naziv_filma} {datum_i_vreme_projekcije}, Sala: {sala}, Cena karte: {cena_karte}";
        }

        public string Kratki {
            get {
                string naziv_filma = $"{film}";
                foreach (Film film in Program.filmovi)
                    if (film.id == this.film)
                        naziv_filma = film.naziv;

                return $"{id}: '{naziv_filma}', {datum_i_vreme_projekcije}"; 
            } 
        }

        public string Korisniku
        {
            get
            {
                Film film_ref = Program.filmovi.Find(x => x.id == this.film);
                Sala sala_ref = Program.sale.Find(x => x.id == this.sala);

                int kapacitet_sale = sala_ref.broj_sedista;
                int zauzeta_mesta = 0;

                foreach (Rezervacija rezervacija in Program.rezervacije)
                    if (rezervacija.id_projekcije == this.id)
                        zauzeta_mesta += rezervacija.broj_mesta;

                int broj_dostupnih_mesta = kapacitet_sale - zauzeta_mesta;


                if (film_ref != null && sala_ref != null)
                    return $"{id}: Film: {film_ref.naziv} Trajanje: {film_ref.trajanje} Datum i vrema: {datum_i_vreme_projekcije} Sala: {sala_ref.broj_sale} Cena karte: {cena_karte} Broj dostupnih mesta: {broj_dostupnih_mesta}";
                else
                    return "Greška!";
            }
        }
    }
}
