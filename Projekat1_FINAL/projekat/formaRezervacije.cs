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
    public partial class formaRezervacije : Form
    {
        public Rezervacija rezervacija;
        public formaAdmin adminFrm;
        public formaKupac kupacFrm;
        public formaRezervacije(formaAdmin adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.kupacFrm = null;
            this.rezervacija = null;
            cmbInit();
            this.Show();
        }
        public formaRezervacije(formaAdmin adminFrm, Rezervacija rezervacija)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.kupacFrm = null;
            this.rezervacija = rezervacija;
            cmbInit();
            this.Show();
        }
        public formaRezervacije(formaKupac kupacFrm, Rezervacija rezervacija)
        {
            InitializeComponent();
            this.adminFrm = null;
            this.kupacFrm = kupacFrm;
            this.rezervacija = rezervacija;
            txtId.Enabled = false;
            cmbKupac.Enabled = false;
            cmbInit();
            this.Show();
        }
        private void cmbInit() {
            cmbProjekcija.DataSource = Program.projekcije;
            cmbProjekcija.DisplayMember = "Kratki";
            cmbKupac.DataSource = Program.kupci;
            cmbKupac.DisplayMember = "Kratki";
        }

        private void frmRezervacije_Load(object sender, EventArgs e)
        {
            if (rezervacija != null)
            {
                txtId.Text = rezervacija.id.ToString();
                cmbProjekcija.SelectedItem = Program.projekcije.Find(x => x.id == rezervacija.id_projekcije);
                cmbKupac.SelectedItem = Program.kupci.Find(x => x.id == rezervacija.id_kupca);
                txtBrMesta.Text = rezervacija.broj_mesta.ToString();
                lbCena.Text = $"Ukupna cena: {rezervacija.ukupna_cena}";
            }
            else
            {
                txtId.Text = Program.IdRezervacije(Program.rezervacije).ToString();
            }
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            int id = Program.IdRezervacije(Program.rezervacije);
            int brmesta;

            if (txtBrMesta.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }

            if (!int.TryParse(txtBrMesta.Text, out brmesta))
            {
                MessageBox.Show("Broj mesta mora biti broj.");
                return;
            }

            if (brmesta == 0)
            {
                MessageBox.Show("Broj mesta mora biti veći od nule.");
                return;
            }

            try
            {
                int zauzeta_mesta = 0;

                foreach (Rezervacija rezervacija in Program.rezervacije)
                    if (rezervacija.id_projekcije == (cmbProjekcija.SelectedItem as Projekcija).id)
                        zauzeta_mesta += rezervacija.broj_mesta;

                int kapacitet_sale = Program.sale.Find(x => x.id == (cmbProjekcija.SelectedItem as Projekcija).sala).broj_sedista;

                bool ima_mesta = kapacitet_sale >= (zauzeta_mesta + int.Parse(txtBrMesta.Text));

                if (!ima_mesta)
                {
                    MessageBox.Show("Nema dovoljno mesta!");
                    return;
                }

                int granica_god = Program.filmovi.Find(x => x.id == (cmbProjekcija.SelectedItem as Projekcija).film).granica_godina;
                if ((DateTime.Now.Year - (cmbKupac.SelectedItem as Kupac).datum_rodjenja.Year) < granica_god) 
                {
                    MessageBox.Show("Godine su ispod granice!");
                    return;
                }                

                if (rezervacija == null)
                {
                    Program.rezervacije.Add(new Rezervacija(
                            id,
                            (cmbProjekcija.SelectedItem as Projekcija).id,
                            (cmbKupac.SelectedItem as Kupac).id,
                            brmesta,
                            (cmbProjekcija.SelectedItem as Projekcija).cena_karte * int.Parse(txtBrMesta.Text)
                        ));
                }
                else
                {
                    rezervacija.id = int.Parse(txtId.Text);
                    rezervacija.id_projekcije = (cmbProjekcija.SelectedItem as Projekcija).id;
                    rezervacija.id_kupca = (cmbKupac.SelectedItem as Kupac).id;
                    rezervacija.broj_mesta = brmesta;
                    rezervacija.ukupna_cena = (cmbProjekcija.SelectedItem as Projekcija).cena_karte * int.Parse(txtBrMesta.Text);
                }
                Program.UpisiSve();
                if (adminFrm != null) adminFrm.RefreshLbs();
                else if (kupacFrm != null) kupacFrm.RefreshLb();
                MessageBox.Show("Sačuvano.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PromeniUkupnuCenu(object sender, EventArgs e)
        {
            if (int.TryParse(txtBrMesta.Text, out int br_mesta))
            {
                double ukupna_cena = (cmbProjekcija.SelectedItem as Projekcija).cena_karte * br_mesta;
                lbCena.Text = $"Ukupna cena: {ukupna_cena}";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbCena_Click(object sender, EventArgs e)
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
