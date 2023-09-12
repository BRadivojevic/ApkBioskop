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
    public partial class formaNovaRezervacija : Form
    {
        public formaKupac kupacFrm;
        public formaNovaRezervacija(formaKupac kupacFrm)
        {
            InitializeComponent();
            this.kupacFrm = kupacFrm;
            this.cmbSala.DataSource = Program.sale;
            this.cmbSala.DisplayMember = "Kratki";
            this.cmbFilm.DataSource = Program.filmovi;
            this.cmbFilm.DisplayMember = "Kratki";
            dtpPocetni.MinDate = DateTime.Now;
            dtpKrajnji.MinDate = DateTime.Now;
            this.Show();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            List<Projekcija> filtrirane_projekcije = new List<Projekcija>();
            foreach (Projekcija projekcija in Program.projekcije)
            {
                if (projekcija.datum_i_vreme_projekcije >= dtpPocetni.Value
                    && projekcija.datum_i_vreme_projekcije <= dtpKrajnji.Value
                    && projekcija.sala == ((Sala)cmbSala.SelectedItem).id
                    && projekcija.film == ((Film)cmbFilm.SelectedItem).id)
                {
                    filtrirane_projekcije.Add(projekcija);
                }
            }
            this.lbProjekcije.DataSource = null;
            this.lbProjekcije.DisplayMember = "Korisniku";
            this.lbProjekcije.DataSource = filtrirane_projekcije;
            if (filtrirane_projekcije.Count == 0) 
            {
                MessageBox.Show("Ne postoje projekcije za odabrane datume.");
                return;
            }
        }

        private void updateCena(object sender, EventArgs e)
        {
            if (lbProjekcije.SelectedItem != null)
            {
                txtUkupnaCena.Text = (((double)nudBrMesta.Value) * ((Projekcija)lbProjekcije.SelectedItem).cena_karte).ToString();
            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            int zauzeta_mesta = 0;

            foreach (Rezervacija rezervacija in Program.rezervacije)
                if (rezervacija.id_projekcije == (lbProjekcije.SelectedItem as Projekcija).id)
                    zauzeta_mesta += rezervacija.broj_mesta;

            int kapacitet_sale = Program.sale.Find(x => x.id == (lbProjekcije.SelectedItem as Projekcija).sala).broj_sedista;

            bool ima_mesta = kapacitet_sale >= (zauzeta_mesta + (int)nudBrMesta.Value);

            int granica_god = Program.filmovi.Find(x => x.id == (cmbFilm.SelectedItem as Film).id).granica_godina;
            if ((DateTime.Now.Year - kupacFrm.kupac.datum_rodjenja.Year) < granica_god)
            {
                MessageBox.Show("Godine su ispod granice!");
                return;
            }

            if(!ima_mesta)
            {
                MessageBox.Show("Nema dovoljno mesta!");
                return;
            }

            if (nudBrMesta.Value == 0)
            {
                MessageBox.Show("Broj mesta mora biti veći od nule.");
                return;
            }

            if (lbProjekcije.SelectedItem != null)
            {
                int id = 0;
                foreach (Rezervacija rez in Program.rezervacije)
                {
                    if (rez.id > id)
                    {
                        id = rez.id;
                    }
                }
                id++;

                Program.rezervacije.Add(new Rezervacija(
                        id,
                        ((Projekcija)lbProjekcije.SelectedItem).id,
                        kupacFrm.kupac.id,
                        (int)nudBrMesta.Value,
                        double.Parse(txtUkupnaCena.Text)
                    ));

                Program.UpisiSve();
                kupacFrm.RefreshLb();

                MessageBox.Show("Uspešna rezervacija!");
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void formaNovaRezervacija_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
