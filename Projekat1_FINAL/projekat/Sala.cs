using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat
{
    [Serializable]
    public class Sala
    {
        public int id;
        public int broj_sale;
        public int broj_sedista;

        public Sala(int id, int broj_sale, int broj_sedista)
        {
            this.id = id;
            this.broj_sale = broj_sale;
            this.broj_sedista = broj_sedista;
        }

        public override string ToString()
        {
            return $"{id}: Broj sale: {broj_sale}, Broj sedišta: {broj_sedista}";
        }

        public string Kratki {
            get => $"ID: {id}, Sala {broj_sale}";
        }        
    }
}
