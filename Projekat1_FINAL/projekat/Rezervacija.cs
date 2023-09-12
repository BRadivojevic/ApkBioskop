using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    public class Rezervacija
    {
        public int id;
        public int id_projekcije;
        public int id_kupca;
        public int broj_mesta;
        public double ukupna_cena;

        public Rezervacija(int id, int id_projekcije, int id_kupca, int broj_mesta, double ukupna_cena)
        {
            this.id = id;
            this.id_projekcije = id_projekcije;
            this.id_kupca = id_kupca;
            this.broj_mesta = broj_mesta;
            this.ukupna_cena = ukupna_cena;
        }

        public override string ToString()
        {
            return $"{id}: ID projekcije: {id_projekcije}, ID Kupca: {id_kupca}, Broj mesta: {broj_mesta}, Ukupna cena: {ukupna_cena}";
        }

        public string Korisniku
        {
            get {
                Projekcija p = Program.projekcije.Find(x => x.id == id_projekcije);
                Film f = Program.filmovi.Find(x => x.id == p.film);
                Sala s = Program.sale.Find(x => x.id == p.sala);
                return $"{id}: Film: {f.naziv}, Vreme: {p.datum_i_vreme_projekcije}, Sala: {s.broj_sale}, Broj mesta: {broj_mesta}, Ukupna cena: {ukupna_cena}";
            }
        }
    }
}
