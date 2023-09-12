using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    public class Film
    {
        public int id;
        public string naziv;
        public string zanr;
        public TimeSpan trajanje;
        public int granica_godina;

        public Film(int id, string naziv, string zanr, TimeSpan trajanje, int granica_godina)
        {
            this.id = id;
            this.naziv = naziv;
            this.zanr = zanr;
            this.trajanje = trajanje;
            this.granica_godina = granica_godina;
        }

        public override string ToString()
        {
            return $"{id}: '{naziv}', Žanr: {zanr}, Trajanje: {trajanje:hh\\:mm}, Granica godina: {granica_godina}";
        }

        public string Kratki {
            get => $"ID: {id}, '{naziv}'";
        }
    }
}
