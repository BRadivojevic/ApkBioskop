using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat
{
    static class Program
    {
        public static List<Sala> sale;
        public static List<Projekcija> projekcije;
        public static List<Rezervacija> rezervacije;
        public static List<Kupac> kupci;
        public static List<Film> filmovi;


        public static void UpisiSve()
        {
            FileStream fs_sale = new FileStream("sale.bin", FileMode.Create);
            FileStream fs_projekcije = new FileStream("projekcije.bin", FileMode.Create);
            FileStream fs_rezervacije = new FileStream("rezervacije.bin", FileMode.Create);
            FileStream fs_kupci = new FileStream("kupci.bin", FileMode.Create);
            FileStream fs_filmovi = new FileStream("filmovi.bin", FileMode.Create);

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs_sale, sale);
            bf.Serialize(fs_projekcije, projekcije);
            bf.Serialize(fs_rezervacije, rezervacije);
            bf.Serialize(fs_kupci, kupci);
            bf.Serialize(fs_filmovi, filmovi);

            fs_filmovi.Close();
            fs_sale.Close();
            fs_rezervacije.Close();
            fs_kupci.Close();
            fs_projekcije.Close();
        }

        public static int IdSale(List<Sala> lista)
        {
            int max_id = 0;
            foreach (Sala item in lista)
                if (item.id > max_id)
                    max_id = item.id;
            return max_id + 1;
        }

        public static int IdProjekcije(List<Projekcija> lista)
        {
            int max_id = 0;
            foreach (Projekcija item in lista)
                if (item.id > max_id)
                    max_id = item.id;
            return max_id + 1;
        }

        public static int IdRezervacije(List<Rezervacija> lista)
        {
            int max_id = 0;
            foreach (Rezervacija item in lista)
                if (item.id > max_id)
                    max_id = item.id;
            return max_id + 1;
        }

        public static int IdKupci(List<Kupac> lista)
        {
            int max_id = 0;
            foreach (Kupac item in lista)
                if (item.id > max_id)
                    max_id = item.id;
            return max_id + 1;
        }

        public static int IdFilmovi(List<Film> lista)
        {
            int max_id = 0;
            foreach (Film item in lista)
                if (item.id > max_id)
                    max_id = item.id;
            return max_id + 1;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            sale        = new List<Sala>();
            projekcije  = new List<Projekcija>();
            rezervacije = new List<Rezervacija>();
            kupci       = new List<Kupac>();
            filmovi     = new List<Film>();

            FileStream fs_sale          = new FileStream("sale.bin", FileMode.OpenOrCreate);
            FileStream fs_projekcije    = new FileStream("projekcije.bin", FileMode.OpenOrCreate);
            FileStream fs_rezervacije   = new FileStream("rezervacije.bin", FileMode.OpenOrCreate);
            FileStream fs_kupci         = new FileStream("kupci.bin", FileMode.OpenOrCreate);
            FileStream fs_filmovi       = new FileStream("filmovi.bin", FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();

            if (fs_sale.Length > 0)         sale        = bf.Deserialize(fs_sale) as List<Sala>;
            if (fs_projekcije.Length > 0)   projekcije  = bf.Deserialize(fs_projekcije) as List<Projekcija>;
            if (fs_rezervacije.Length > 0)  rezervacije = bf.Deserialize(fs_rezervacije) as List<Rezervacija>;
            if (fs_kupci.Length > 0)        kupci       = bf.Deserialize(fs_kupci) as List<Kupac>;
            if (fs_filmovi.Length > 0)      filmovi     = bf.Deserialize(fs_filmovi) as List<Film>;

            fs_filmovi.Close();
            fs_sale.Close();
            fs_rezervacije.Close();
            fs_kupci.Close();
            fs_projekcije.Close();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formaPocetna());
        }
    }
}
