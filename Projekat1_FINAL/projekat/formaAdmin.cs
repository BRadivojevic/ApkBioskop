using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat
{
    public partial class formaAdmin : Form
    {
        public formaAdmin()
        {
            InitializeComponent();

            cmbKupci.DataSource = Program.kupci;
            cmbKupci.DisplayMember = "Kratki";
            InitLbs();
        }

        private void InitLbs()
        {
            lbSale.DataSource = Program.sale;
            lbFilmovi.DataSource = Program.filmovi;
            lbKupci.DataSource = Program.kupci;
            lbProjekcije.DataSource = Program.projekcije;

            lbRezervacije.DataSource = Program.rezervacije.FindAll(x => x.id_kupca == (cmbKupci.SelectedItem as Kupac).id);
        }

        public void RefreshLbs()
        {
            lbFilmovi.DataSource = null;
            lbProjekcije.DataSource = null;
            lbSale.DataSource = null;
            lbRezervacije.DataSource = null;
            lbKupci.DataSource = null;
            InitLbs();
        }

        private void filmoviDodaj_Click(object sender, EventArgs e)
        {
            new formaFilmovi(this);            
        }

        private void filmoviEdituj_Click(object sender, EventArgs e) 
        {
            new formaFilmovi(this, (Film)lbFilmovi.SelectedItem);
        }            

        private void filmoviIzbrisi_Click(object sender, EventArgs e)
        {
            int br = 0;
            foreach (Projekcija item in Program.projekcije)
            {
                if ((lbFilmovi.SelectedItem as Film).id == item.film)
                {
                    br++;             
                }
            }

            if (br == 0)
            {
                Program.filmovi.Remove((Film)lbFilmovi.SelectedItem);
                Program.UpisiSve();
                RefreshLbs();
                MessageBox.Show("Uspešno obrisan film.");
            }
            else
            {
                MessageBox.Show("Film se ne može izbrisati zbog postojećih projekcija.");
                return;
            }
        }
        
        private void saleDodaj_Click(object sender, EventArgs e)
        {
            new formaSale(this);
        }            

        private void saleEdituj_Click(object sender, EventArgs e)
        {
            new formaSale(this, (Sala)lbSale.SelectedItem);
        }

        private void saleIzbrisi_Click(object sender, EventArgs e)
        {
            int br = 0;
            foreach (Projekcija item in Program.projekcije)
            {
                if ((lbSale.SelectedItem as Sala).id == item.sala)
                {
                    br++;
                }
            }

            if (br == 0)
            {
                Program.sale.Remove((Sala)lbSale.SelectedItem);
                Program.UpisiSve();
                RefreshLbs();
                MessageBox.Show("Uspešno izbrisana sala.");
            }
            else
            {
                MessageBox.Show("Sala se ne može izbrisati zbog postojećih projekcija.");
                return;
            }
        }
        
        private void projekcijeDodaj_Click(object sender, EventArgs e)
        {
            new formaProjekcije(this);
        }

        private void projekcijeEdituj_Click(object sender, EventArgs e)
        {
            new formaProjekcije(this, (Projekcija)lbProjekcije.SelectedItem);
        }

        private void projekcijeIzbrisi_Click(object sender, EventArgs e)
        {
            int br = 0;
            foreach (Rezervacija item in Program.rezervacije)
            {
                if ((lbProjekcije.SelectedItem as Projekcija).id == item.id_projekcije)
                {
                    br++;
                }
            }

            if (br == 0)
            {
                Program.projekcije.Remove((Projekcija)lbProjekcije.SelectedItem);
                Program.UpisiSve();
                RefreshLbs();
                MessageBox.Show("Uspešno izbrisana projekcija.");
            }
            else
            {
                MessageBox.Show("Projekcija se ne može izbrisati zbog postojećih rezervacija.");
                return;
            }
        }

        private void kupciDodaj_Click(object sender, EventArgs e)
        {
            new formaKupci(this);
        }

        private void kupciEdituj_Click(object sender, EventArgs e)
        {
            new formaKupci(this, (Kupac)lbKupci.SelectedItem);
        }

        private void kupciIzbrisi_Click(object sender, EventArgs e)
        {
            int br = 0;
            foreach (Rezervacija item in Program.rezervacije)
            {
                if ((lbKupci.SelectedItem as Kupac).id == item.id_kupca)
                {
                    br++;
                }
            }

            if (br == 0)
            {
                Program.kupci.Remove((Kupac)lbKupci.SelectedItem);
                Program.UpisiSve();
                RefreshLbs();
                MessageBox.Show("Uspešno izbrisan kupac.");
            }
            else
            {
                MessageBox.Show("Kupac se ne može izbrisati zbog postojećih rezervacija.");
                return;
            }
        }

        private void rezervacijeDodaj_Click(object sender, EventArgs e)
        {
            new formaRezervacije(this);
        }

        private void rezervacijeEdituj_Click(object sender, EventArgs e)
        {
            new formaRezervacije(this, (Rezervacija)lbRezervacije.SelectedItem);
        }

        private void rezervacijeIzbrisi_Click(object sender, EventArgs e)
        {
            Program.rezervacije.Remove((Rezervacija)lbRezervacije.SelectedItem);
            Program.UpisiSve();
            RefreshLbs();
            MessageBox.Show("Uspešno izbrisana rezervacija.");
        }

        private void FilterList(object sender, EventArgs e)
        {
            lbRezervacije.DataSource = null;
            lbRezervacije.DataSource = Program.rezervacije.FindAll(x => x.id_kupca == (cmbKupci.SelectedItem as Kupac).id);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
