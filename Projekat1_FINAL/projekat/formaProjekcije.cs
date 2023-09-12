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
    public partial class formaProjekcije : Form
    {
        public Projekcija projekcija;
        public formaAdmin adminFrm;
        public formaProjekcije(formaAdmin adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.projekcija = null;
            cmbInit();
            dtpVremeDatum.MinDate = DateTime.Now;
            this.Show();
        }

        public formaProjekcije(formaAdmin adminFrm, Projekcija projekcija)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.projekcija = projekcija;
            cmbInit();
            this.Show();
        }

        private void cmbInit() {
            cmbSala.DataSource = Program.sale;
            cmbSala.DisplayMember = "Kratki";
            cmbFilm.DataSource = Program.filmovi;
            cmbFilm.DisplayMember = "Kratki";
        }

        private void frmProjekcije_Load(object sender, EventArgs e)
        {
            if (projekcija != null)
            {
                txtId.Text = projekcija.id.ToString();
                dtpVremeDatum.Value = projekcija.datum_i_vreme_projekcije;
                cmbSala.SelectedItem = Program.sale.Find(x => x.id == projekcija.sala);
                txtCenaKarte.Text = projekcija.cena_karte.ToString();
                cmbFilm.SelectedItem = Program.filmovi.Find(x => x.id == projekcija.film);
            }
            else
            {
                txtId.Text = Program.IdProjekcije(Program.projekcije).ToString();
            }
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            int id = Program.IdProjekcije(Program.projekcije);
            double cenakarte;

            if (txtCenaKarte.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }

            if (!double.TryParse(txtCenaKarte.Text, out cenakarte))
            {
                MessageBox.Show("Cena karte ne sme sadržati slova.");
                return;
            }            

            try
            {
                if (projekcija == null)
                {
                    Program.projekcije.Add(new Projekcija(
                            id,
                            dtpVremeDatum.Value,
                            (cmbSala.SelectedItem as Sala).id,
                            cenakarte,
                            (cmbFilm.SelectedItem as Film).id
                        ));
                }
                else
                {
                    projekcija.id = int.Parse(txtId.Text);
                    projekcija.datum_i_vreme_projekcije = dtpVremeDatum.Value;
                    projekcija.sala = (cmbSala.SelectedItem as Sala).id;
                    projekcija.cena_karte = cenakarte;
                    projekcija.film = (cmbFilm.SelectedItem as Film).id;
                }
                Program.UpisiSve();
                adminFrm.RefreshLbs();
                MessageBox.Show("Sačuvano.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
