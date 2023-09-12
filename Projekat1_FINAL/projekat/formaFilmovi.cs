using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat
{
    public partial class formaFilmovi : Form
    {
        public Film film;
        public formaAdmin adminFrm;
        public formaFilmovi(formaAdmin adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.film = null;
            this.Show();
        }

        public formaFilmovi(formaAdmin adminFrm, Film film)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.film = film;
            this.Show();
        }

        private void frmFilmovi_Load(object sender, EventArgs e)
        {
            if (film != null)
            {
                txtID.Text = film.id.ToString();
                txtNaziv.Text = film.naziv;
                txtZanr.Text = film.zanr;
                txtTrajanje.Text = film.trajanje.TotalMinutes.ToString();
                txtGranicaGodina.Text = film.granica_godina.ToString();
            }
            else
            {
                txtID.Text = Program.IdFilmovi(Program.filmovi).ToString();
            }
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            int trajanje = 0;
            int granicagod = 0;
            Regex reg = new Regex("^[a-zA-Z\x20]+$");

            if (txtNaziv.Text.Length == 0 ||
                txtZanr.Text.Length == 0 ||
                txtTrajanje.Text.Length == 0 ||
                txtGranicaGodina.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }

            if (!reg.IsMatch(txtZanr.Text))
            {
                MessageBox.Show("Žanr ne sme sadržati brojeve.");
                return;
            }

            if (!int.TryParse(txtTrajanje.Text, out trajanje) ||
                !int.TryParse(txtGranicaGodina.Text, out granicagod))
            {
                MessageBox.Show("Trajanje filma i granica godina trebaju biti broj.");
                return;
            }

            int id = Program.IdFilmovi(Program.filmovi);
            try
            {
                if (film == null)
                {
                    Program.filmovi.Add(new Film(
                            id,
                            txtNaziv.Text,
                            txtZanr.Text,
                            new TimeSpan(0, trajanje, 0),
                            granicagod
                        ));
                }
                else
                {
                    film.id = int.Parse(txtID.Text);
                    film.naziv = txtNaziv.Text;
                    film.zanr = txtZanr.Text;
                    film.trajanje = new TimeSpan(0, trajanje, 0);
                    film.granica_godina = granicagod;
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
